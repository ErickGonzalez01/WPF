using System;
using System.Collections.Generic;

namespace System_Retail_Operation_POS.Model;

public partial class TransactionLog
{
    public int Id { get; set; }

    public int? ClientId { get; set; }

    public decimal Total { get; set; }

    public decimal TotalDelivered { get; set; }

    public decimal Change { get; set; }

    public virtual Client? Client { get; set; }

    public virtual ICollection<Movement> Movements { get; set; } = new List<Movement>();

    public virtual ICollection<TransitionPaymentMethod> TransitionPaymentMethods { get; set; } = new List<TransitionPaymentMethod>();
}
