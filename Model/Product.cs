using System;
using System.Collections.Generic;

namespace System_Retail_Operation_POS.Model;

public partial class Product
{
    public int Id { get; set; }

    public string BarCode { get; set; } = null!;

    public int CategoryId { get; set; }

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }

    public int? ParentProductId { get; set; }

    public int? QuantityProductsChildren { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Product> InverseParentProduct { get; set; } = new List<Product>();

    public virtual ICollection<Movement> Movements { get; set; } = new List<Movement>();

    public virtual Product? ParentProduct { get; set; }
}
