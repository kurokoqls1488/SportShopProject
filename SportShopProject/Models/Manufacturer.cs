using System;
using System.Collections.Generic;

namespace SportShopProject.Models;

public partial class Manufacturer
{
    public short Id { get; set; }

    public string NameManufacturer { get; set; } = null!;

    public virtual ICollection<SportsGood> SportsGoods { get; set; } = new List<SportsGood>();
}
