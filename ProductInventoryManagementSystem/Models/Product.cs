using System;
using System.Collections.Generic;

namespace ProductInventoryManagementSystem.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string Category { get; set; } = null!;

    public decimal Price { get; set; }

    public int StockLevel { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
