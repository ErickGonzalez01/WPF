using System;
using System.Collections.Generic;

namespace System_Retail_Operation_POS.Model;

public partial class CurrencyType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string RegionOrCountry { get; set; } = null!;

    public string? Symbol { get; set; }

    public virtual ICollection<PaymentMethod> PaymentMethods { get; set; } = new List<PaymentMethod>();
}
