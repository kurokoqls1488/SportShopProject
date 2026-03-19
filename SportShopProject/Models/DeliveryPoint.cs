using System;
using System.Collections.Generic;

namespace SportShopProject.Models;

public partial class DeliveryPoint
{
    public short Id { get; set; }

    public string DeliveryAddres { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
