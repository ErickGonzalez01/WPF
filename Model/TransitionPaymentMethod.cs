using System;
using System.Collections.Generic;

namespace System_Retail_Operation_POS.Model;

public partial class TransitionPaymentMethod
{
    public int Id { get; set; }

    public int PaymentMethodId { get; set; }

    public int TransactionLogId { get; set; }

    public decimal Amount { get; set; }

    public virtual PaymentMethod PaymentMethod { get; set; } = null!;

    public virtual TransactionLog TransactionLog { get; set; } = null!;
}
