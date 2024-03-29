using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class Order
{
    public int OrderId { get; set; }

    public int? UserId { get; set; }

    public double? TotalPrice { get; set; }

    public int? TotalQuantity { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? ShippedDate { get; set; }

    public int? StatusId { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Status? Status { get; set; }

    public virtual User? User { get; set; }
}
