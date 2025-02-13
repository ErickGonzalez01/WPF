using System;
using System.Collections.Generic;

namespace System_Retail_Operation_POS.Model;

public partial class Inventory
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string? ReferenceNumber { get; set; }

    public int? ProviderId { get; set; }

    public virtual ICollection<Movement> Movements { get; set; } = new List<Movement>();

    public virtual Provider? Provider { get; set; }
}
