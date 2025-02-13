using System;
using System.Collections.Generic;

namespace System_Retail_Operation_POS.Model;

public partial class User
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Movement> Movements { get; set; } = new List<Movement>();

    public virtual ICollection<UserRoll> UserRolls { get; set; } = new List<UserRoll>();
}
