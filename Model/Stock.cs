using System;
using System.Collections.Generic;

namespace System_Retail_Operation_POS.Model;

public partial class Stock
{
    public int Id { get; set; }

    public DateOnly Date { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }
}
