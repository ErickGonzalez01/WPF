using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace System_Retail_Operation_POS.Model;

public partial class SystemPosContext : DbContext
{
    public SystemPosContext()
    {
    }

    public SystemPosContext(DbContextOptions<SystemPosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<CurrencyType> CurrencyTypes { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<Movement> Movements { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Provider> Providers { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RolesOnPermission> RolesOnPermissions { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public virtual DbSet<TransactionLog> TransactionLogs { get; set; }

    public virtual DbSet<TransitionPaymentMethod> TransitionPaymentMethods { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserRoll> UserRolls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=System_POS;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Category__3214EC07F8A41B8B");

            entity.ToTable("Category");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Client__3214EC079CD0A411");

            entity.ToTable("Client");

            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Department)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FirsName)
                .HasMaxLength(55)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(55)
                .IsUnicode(false);
            entity.Property(e => e.Municipality)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Quarter)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CurrencyType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Currency__3214EC076A3D5FCB");

            entity.ToTable("CurrencyType");

            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RegionOrCountry)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Symbol)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Inventor__3214EC073CBA96E1");

            entity.ToTable("Inventory");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Provider).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.ProviderId)
                .HasConstraintName("FK__Inventory__Provi__4CA06362");
        });

        modelBuilder.Entity<Movement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Movement__3214EC07D77DE7A9");

            entity.ToTable("Movement");

            entity.Property(e => e.TypeMovement)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Inventory).WithMany(p => p.Movements)
                .HasForeignKey(d => d.InventoryId)
                .HasConstraintName("FK__Movement__Invent__60A75C0F");

            entity.HasOne(d => d.Product).WithMany(p => p.Movements)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Movement__Produc__619B8048");

            entity.HasOne(d => d.Transaction).WithMany(p => p.Movements)
                .HasForeignKey(d => d.TransactionId)
                .HasConstraintName("FK__Movement__Transa__628FA481");

            entity.HasOne(d => d.User).WithMany(p => p.Movements)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Movement__UserId__5FB337D6");
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PaymentM__3214EC07E8418FEB");

            entity.ToTable("PaymentMethod");

            entity.Property(e => e.TypeName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.CurrencyType).WithMany(p => p.PaymentMethods)
                .HasForeignKey(d => d.CurrencyTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PaymentMe__Curre__534D60F1");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Permissi__3214EC0798B9ABDE");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product__3214EC071B25D66E");

            entity.ToTable("Product");

            entity.HasIndex(e => e.BarCode, "UQ__Product__8A2ACA9B29768C84").IsUnique();

            entity.Property(e => e.BarCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Product__Categor__46E78A0C");

            entity.HasOne(d => d.ParentProduct).WithMany(p => p.InverseParentProduct)
                .HasForeignKey(d => d.ParentProductId)
                .HasConstraintName("FK__Product__ParentP__47DBAE45");
        });

        modelBuilder.Entity<Provider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Provider__3214EC07DE00A6E0");

            entity.ToTable("Provider");

            entity.Property(e => e.AgentName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AlternatePhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Roles__3214EC0738381220");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RolesOnPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RolesOnP__3214EC0733B80E96");

            entity.HasOne(d => d.Permisson).WithMany(p => p.RolesOnPermissions)
                .HasForeignKey(d => d.PermissonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RolesOnPe__Permi__6A30C649");

            entity.HasOne(d => d.Rol).WithMany(p => p.RolesOnPermissions)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RolesOnPe__RolId__693CA210");
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Stocks__3214EC078CA82856");
        });

        modelBuilder.Entity<TransactionLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Transact__3214EC07E131ADFC");

            entity.ToTable("TransactionLog");

            entity.Property(e => e.Change).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TotalDelivered).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Client).WithMany(p => p.TransactionLogs)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK__Transacti__Clien__5629CD9C");
        });

        modelBuilder.Entity<TransitionPaymentMethod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Transiti__3214EC07FFFDE7C6");

            entity.ToTable("TransitionPaymentMethod");

            entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.PaymentMethod).WithMany(p => p.TransitionPaymentMethods)
                .HasForeignKey(d => d.PaymentMethodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Transitio__Payme__59063A47");

            entity.HasOne(d => d.TransactionLog).WithMany(p => p.TransitionPaymentMethods)
                .HasForeignKey(d => d.TransactionLogId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Transitio__Trans__59FA5E80");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC07DA9E07A4");

            entity.Property(e => e.FullName)
                .HasMaxLength(55)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UserName)
                .HasMaxLength(55)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserRoll>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserRoll__3214EC0750B90A4C");

            entity.ToTable("UserRoll");

            entity.HasOne(d => d.Rol).WithMany(p => p.UserRolls)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserRoll__RolId__6E01572D");

            entity.HasOne(d => d.User).WithMany(p => p.UserRolls)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserRoll__UserId__6D0D32F4");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
