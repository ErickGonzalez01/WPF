using System;
using System.Collections.Generic;

namespace System_Retail_Operation_POS.Model;

public partial class Permission
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<RolesOnPermission> RolesOnPermissions { get; set; } = new List<RolesOnPermission>();
}
