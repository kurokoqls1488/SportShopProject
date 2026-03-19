using System;
using System.Collections.Generic;

namespace SportShopProject.Models;

public partial class Category
{
    public short Id { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<SportsGood> SportsGoods { get; set; } = new List<SportsGood>();
}
