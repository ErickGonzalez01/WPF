using System;
using System.Collections.Generic;

namespace System_Retail_Operation_POS.Model;

public partial class PaymentMethod
{
    public int Id { get; set; }

    public string TypeName { get; set; } = null!;

    public int CurrencyTypeId { get; set; }

    public virtual CurrencyType CurrencyType { get; set; } = null!;

    public virtual ICollection<TransitionPaymentMethod> TransitionPaymentMethods { get; set; } = new List<TransitionPaymentMethod>();
}
