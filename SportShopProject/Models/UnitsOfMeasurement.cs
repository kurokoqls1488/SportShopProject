using System;
using System.Collections.Generic;

namespace SportShopProject.Models;

public partial class UnitsOfMeasurement
{
    public short Id { get; set; }

    public string NameUnits { get; set; } = null!;

    public virtual ICollection<SportsGood> SportsGoods { get; set; } = new List<SportsGood>();
}
