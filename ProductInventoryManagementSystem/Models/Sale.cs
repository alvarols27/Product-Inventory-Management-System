using System;
using System.Collections.Generic;

namespace ProductInventoryManagementSystem.Models;

public partial class Sale
{
    public int SaleId { get; set; }

    public int ProductId { get; set; }

    public int CustomerId { get; set; }

    public int QuantitySold { get; set; }

    public DateTime SaleDate { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
