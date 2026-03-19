using System;
using System.Collections.Generic;

namespace SportShopProject.Models;

public partial class SportsGood
{
    public short Id { get; set; }

    public string Articul { get; set; } = null!;

    public string NameGoods { get; set; } = null!;

    public short IdCategory { get; set; }

    public short IdManufacturer { get; set; }

    public short IdSupplier { get; set; }

    public decimal Price { get; set; }

    public short IdUnitsOfMeasurement { get; set; }

    public int Discount { get; set; }

    public int CountInStock { get; set; }

    public string Description { get; set; } = null!;

    public virtual Category IdCategoryNavigation { get; set; } = null!;

    public virtual Manufacturer IdManufacturerNavigation { get; set; } = null!;

    public virtual Supplier IdSupplierNavigation { get; set; } = null!;

    public virtual UnitsOfMeasurement IdUnitsOfMeasurementNavigation { get; set; } = null!;

    public virtual ICollection<OrdersStortGood> OrdersStortGoods { get; set; } = new List<OrdersStortGood>();
}
