using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class Product
{
    public int ProductId { get; set; }

    public int? CategoryId { get; set; }

    public string? ProductName { get; set; }

    public string? ProductImage { get; set; }

    public string? ProductDescription { get; set; }

    public double? UnitPrice { get; set; }

    public int? Discount { get; set; }

    public int? UnitInStock { get; set; }

    public int? ProductStatus { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual Category? Category { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
