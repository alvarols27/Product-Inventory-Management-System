using System;
using System.Collections.Generic;

namespace ProductInventoryManagementSystem.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string? Email { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
