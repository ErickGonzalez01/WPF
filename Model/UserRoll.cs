using System;
using System.Collections.Generic;

namespace System_Retail_Operation_POS.Model;

public partial class UserRoll
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int RolId { get; set; }

    public virtual Role Rol { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
