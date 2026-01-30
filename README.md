# Product-Inventory-Management-System
The Product Inventory Management System is a professional desktop application that provides complete CRUD operations for managing a retail business. Built with modern .NET technologies and SQL Server, it demonstrates enterprise-level database management, data validation, and user-friendly interface design.

# Key Features

### Product Management
- ✅ Add new products with category, price, and stock level
- ✅ Update existing product information
- ✅ Delete products from inventory
- ✅ View all products or filter by selection
- ✅ Auto-fill form fields when selecting products

### Customer Management
- ✅ Add new customers with contact information
- ✅ Update customer details
- ✅ Delete customer records
- ✅ Email and phone number validation
- ✅ Unique email constraint enforcement

### Sales Management
- ✅ Record sales transactions
- ✅ Automatic inventory deduction
- ✅ Stock availability validation
- ✅ Customer and product linking
- ✅ Date tracking for all sales

### Inventory Alerts
- ✅ Low stock alert system (threshold: 10 units)
- ✅ Real-time stock level monitoring
- ✅ Automatic alerts after sales
- ✅ DataGridView display for low-stock items

### Data Validation
- ✅ Email format validation
- ✅ Phone number format validation (e.g., (123) 456-7890)
- ✅ Price validation (positive decimal values)
- ✅ Stock level validation (positive integers)
- ✅ Required field checking

## 🏗️ Technology Stack

- **Framework**: .NET 9.0 Windows Forms
- **ORM**: Entity Framework Core 9.0
- **Database**: SQL Server
- **Architecture**: Database-First Approach
- **Language**: C# 12

### NuGet Packages
```xml
Microsoft.EntityFrameworkCore (9.0.0)
Microsoft.EntityFrameworkCore.SqlServer (9.0.0)
Microsoft.EntityFrameworkCore.Tools (9.0.0)
Microsoft.EntityFrameworkCore.Design (9.0.0)
```

## 📊 Database Schema

### Tables

**Products**
- ProductID (PK, int)
- ProductName (varchar(100), NOT NULL)
- Category (varchar(50), NOT NULL)
- Price (decimal(10,2), NOT NULL)
- StockLevel (int, NOT NULL)

**Customers**
- CustomerID (PK, int)
- CustomerName (varchar(100), NOT NULL)
- PhoneNumber (varchar(15), NOT NULL)
- Email (varchar(100), UNIQUE, NULLABLE)

**Sales**
- SaleID (PK, int)
- ProductID (FK, int)
- CustomerID (FK, int)
- QuantitySold (int, NOT NULL)
- SaleDate (datetime, NOT NULL)

### Relationships
- **Products** → **Sales** (One-to-Many)
- **Customers** → **Sales** (One-to-Many)

## 🚀 Getting Started

### Prerequisites

- .NET 9.0 SDK or later
- SQL Server (LocalDB, Express, or Full Edition)
- Visual Studio 2022 (recommended) or Visual Studio Code
- Windows OS (Windows Forms application)

### Installation

1. **Clone the repository**
```bash
git clone https://github.com/yourusername/product-inventory-management.git
cd product-inventory-management
```

2. **Set up the database**

Create a new database in SQL Server:
```sql
CREATE DATABASE ProductInventoryManagementSystem;
```

Run the schema creation script (create tables with relationships):
```sql
USE ProductInventoryManagementSystem;

CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName VARCHAR(100) NOT NULL,
    Category VARCHAR(50) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    StockLevel INT NOT NULL
);

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    CustomerName VARCHAR(100) NOT NULL,
    PhoneNumber VARCHAR(15) NOT NULL,
    Email VARCHAR(100) UNIQUE
);

CREATE TABLE Sales (
    SaleID INT PRIMARY KEY IDENTITY(1,1),
    ProductID INT NOT NULL,
    CustomerID INT NOT NULL,
    QuantitySold INT NOT NULL,
    SaleDate DATETIME NOT NULL,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);
```

3. **Update the connection string**

In `ProductInventoryManagementSystemContext.cs`, update the connection string to match your SQL Server instance:
```csharp
optionsBuilder.UseSqlServer("Server=YOUR_SERVER_NAME;Database=ProductInventoryManagementSystem;Trusted_Connection=True;TrustServerCertificate=True;");
```

4. **Restore NuGet packages**
```bash
dotnet restore
```

5. **Build the project**
```bash
dotnet build
```

6. **Run the application**
```bash
dotnet run
```

## 💻 Usage Guide

### Adding a Product
1. Navigate to the "Product Management" tab
2. Fill in product details:
   - Product Name
   - Category
   - Price (must be > 0)
   - Stock Level (must be > 0)
3. Click "Save" to add the product

### Recording a Sale
1. Navigate to the "Sales Management" tab
2. Select a product from the dropdown
3. Select a customer from the dropdown
4. Enter quantity to sell
5. Choose the sale date
6. Click "Record" to process the sale
   - Stock will be automatically deducted
   - Low stock alert will trigger if stock falls below 10

### Managing Customers
1. Navigate to the "Customer Management" tab
2. Add customer with:
   - Customer Name
   - Phone Number (format: (123) 456-7890 or 123-456-7890)
   - Email (must be unique and valid)
3. Update or delete customers as needed

### Viewing Inventory
- Use the DataGridView to see all products
- Check the "Low Stock Alert" section for items needing restocking
- Filter products using the dropdown selector

## 🎯 Key Features Explained

### Entity Framework Core Integration
The application uses EF Core with:
- **DbContext**: `ProductInventoryManagementSystemContext`
- **Navigation Properties**: Automatic relationship loading
- **LINQ Queries**: Type-safe database queries
- **Change Tracking**: Automatic update detection

### Validation System
```csharp
// Email validation using .NET MailAddress
private bool IsValidEmail(string email)

// Phone validation using Regex
private bool IsValidPhoneNumber(string phoneNumber)
```

### Stock Management
- Automatic stock deduction on sales
- Pre-sale stock availability check
- Low stock threshold monitoring (< 10 units)
- Real-time alerts

### Data Integrity
- Foreign key constraints
- Unique email constraint
- Required field validation
- Database-level data type enforcement

## 📁 Project Structure

```
ProductInventoryManagementSystem/
├── Models/
│   ├── Product.cs                           # Product entity
│   ├── Customer.cs                          # Customer entity
│   ├── Sale.cs                              # Sale entity
│   └── ProductInventoryManagementSystemContext.cs  # EF Core DbContext
├── Form1.cs                                 # Main form logic
├── Form1.Designer.cs                        # Form designer code
├── Program.cs                               # Application entry point
├── ProductInventoryManagementSystem.csproj  # Project file
└── README.md                                # This file
```

## 🔧 Database Scaffolding

This project was created using EF Core's database-first approach:

```bash
Scaffold-DbContext "Server=YOUR_SERVER;Database=ProductInventoryManagementSystem;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
```

## 🛡️ Security Considerations

⚠️ **Important**: The connection string is currently hardcoded in the `DbContext`. For production use:

1. Move the connection string to `appsettings.json`
2. Use user secrets for development
3. Use environment variables for production
4. Implement proper authentication and authorization

## 🤝 Contributing

Contributions are welcome! To contribute:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 Best Practices Demonstrated

- ✅ Entity Framework Core ORM usage
- ✅ Database-first development approach
- ✅ CRUD operations with proper error handling
- ✅ Input validation and sanitization
- ✅ Navigation properties for relationships
- ✅ LINQ queries for data retrieval
- ✅ Transaction management through EF Core
- ✅ User-friendly error messages
- ✅ Separation of concerns (Models layer)

## 🚧 Future Enhancements

- [ ] Add user authentication and role-based access
- [ ] Implement reporting and analytics dashboard
- [ ] Add export functionality (Excel, PDF)
- [ ] Create product barcode support
- [ ] Add multi-location inventory tracking
- [ ] Implement purchase order management
- [ ] Add supplier management
- [ ] Create mobile-responsive web version

# 🙏Acknowledgments

- Built with Entity Framework Core
- SQL Server for robust data storage
- Windows Forms for desktop UI
- Modern .NET 9.0 framework
