using System;
using System.Collections.Generic;

namespace SportShopProject.Models;

public partial class OrdersStortGood
{
    public short Id { get; set; }

    public short IdOrder { get; set; }

    public short IdSportGood { get; set; }

    public int Quantity { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual SportsGood SportsGood { get; set; } = null!;
}
