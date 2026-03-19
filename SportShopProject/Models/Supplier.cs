using System;
using System.Collections.Generic;

namespace SportShopProject.Models;

public partial class Supplier
{
    public short Id { get; set; }

    public string NameSupplier { get; set; } = null!;

    public virtual ICollection<SportsGood> SportsGoods { get; set; } = new List<SportsGood>();
}
