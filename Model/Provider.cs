using System;
using System.Collections.Generic;

namespace System_Retail_Operation_POS.Model;

public partial class Provider
{
    public int Id { get; set; }

    public string? CompanyName { get; set; }

    public string? AgentName { get; set; }

    public string? Email { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string? AlternatePhoneNumber { get; set; }

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
}
