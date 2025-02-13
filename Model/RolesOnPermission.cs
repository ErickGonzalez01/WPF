using System;
using System.Collections.Generic;

namespace System_Retail_Operation_POS.Model;

public partial class RolesOnPermission
{
    public int Id { get; set; }

    public int RolId { get; set; }

    public int PermissonId { get; set; }

    public virtual Permission Permisson { get; set; } = null!;

    public virtual Role Rol { get; set; } = null!;
}
