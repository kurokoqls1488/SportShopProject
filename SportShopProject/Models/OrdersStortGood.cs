using System;
using System.Collections.Generic;

namespace SportShopProject.Models;

public partial class OrdersStortGood
{
    public short Id { get; set; }

    public short IdOrder { get; set; }

    public short IdSportGood { get; set; }

    public int Quantity { get; set; }

    public virtual Order IdOrderNavigation { get; set; } = null!;

    public virtual SportsGood IdSportGoodNavigation { get; set; } = null!;
}
