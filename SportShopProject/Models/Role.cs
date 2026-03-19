using System;
using System.Collections.Generic;

namespace SportShopProject.Models;

public partial class Role
{
    public short Id { get; set; }

    public string NameRole { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
