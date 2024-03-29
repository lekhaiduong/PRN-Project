using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class OrderDetail
{
    public int OrderDetailId { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public int? QuantityPerUnit { get; set; }

    public double? UnitPrice { get; set; }

    public int? Discount { get; set; }

    public virtual Order? Order { get; set; }

    public virtual Product? Product { get; set; }
}
