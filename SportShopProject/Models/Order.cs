using System;
using System.Collections.Generic;

namespace SportShopProject.Models;

public partial class Order
{
    public short Id { get; set; }

    public DateOnly OrderDate { get; set; }

    public DateOnly DeliveryDate { get; set; }

    public short IdDeliveryPoint { get; set; }

    public short IdUser { get; set; }

    public int Code { get; set; }

    public short IdStatus { get; set; }

    public virtual DeliveryPoint DeliveryPoint { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public virtual ICollection<OrdersStortGood> OrdersStortGoods { get; set; } = new List<OrdersStortGood>();
}
