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

    public virtual DeliveryPoint IdDeliveryPointNavigation { get; set; } = null!;

    public virtual Status IdStatusNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual ICollection<OrdersStortGood> OrdersStortGoods { get; set; } = new List<OrdersStortGood>();
}
