using System;
using System.Collections.Generic;

namespace System_Retail_Operation_POS.Model;

public partial class Movement
{
    public int Id { get; set; }

    public DateOnly Date { get; set; }

    public int UserId { get; set; }

    public int? InventoryId { get; set; }

    public int ProductId { get; set; }

    public int? TransactionId { get; set; }

    public string TypeMovement { get; set; } = null!;

    public int Quantity { get; set; }

    public virtual Inventory? Inventory { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual TransactionLog? Transaction { get; set; }

    public virtual User User { get; set; } = null!;
}
