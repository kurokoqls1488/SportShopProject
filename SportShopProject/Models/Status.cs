using System;
using System.Collections.Generic;

namespace SportShopProject.Models;

public partial class Status
{
    public short Id { get; set; }

    public string NameStatus { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
