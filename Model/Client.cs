using System;
using System.Collections.Generic;

namespace System_Retail_Operation_POS.Model;

public partial class Client
{
    public int Id { get; set; }

    public string FirsName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Department { get; set; } = null!;

    public string Municipality { get; set; } = null!;

    public string Quarter { get; set; } = null!;

    public string Address { get; set; } = null!;

    public virtual ICollection<TransactionLog> TransactionLogs { get; set; } = new List<TransactionLog>();
}
