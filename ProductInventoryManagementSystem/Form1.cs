using Microsoft.EntityFrameworkCore;
using ProductInventoryManagementSystem.Models;

//Scaffold-DbContext "Server=alvaro_ls27;Database=ProductInventoryManagementSystem;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

namespace ProductInventoryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //PRODUCT MANAGEMENT//
        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (var context = new ProductInventoryManagementSystemContext())
            {
                try
                {
                    string productName = textBoxProductNameAdd.Text;
                    string category = textBoxCategoryAdd.Text;
                    decimal price;
                    int stockLevel;

                    if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(category))
                    {
                        MessageBox.Show("Product name and category cannot be empty.", "An error occurred whilst adding a product!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!decimal.TryParse(textBoxPriceAdd.Text, out price) || price <= 0)
                    {
                        MessageBox.Show("The price must be a positive number and/or higher than 0. Please, try again", "An error occurred whilst adding a product!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!int.TryParse(textBoxStockLevelAdd.Text, out stockLevel) || stockLevel <= 0)
                    {
                        MessageBox.Show("Enter a valid stock level.", "An error occurred whilst adding a product!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var newProduct = new Product
                    {
                        ProductName = textBoxProductNameAdd.Text,
                        Category = textBoxCategoryAdd.Text,
                        Price = decimal.Parse(textBoxPriceAdd.Text),
                        StockLevel = int.Parse(textBoxStockLevelAdd.Text)
                    };

                    context.Products.Add(newProduct);
                    context.SaveChanges();
                    MessageBox.Show($"Product '{productName}' added successfully!", "Successful operation!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Clear fields after saving
                    textBoxProductNameAdd.Clear();
                    textBoxCategoryAdd.Clear();
                    textBoxPriceAdd.Clear();
                    textBoxStockLevelAdd.Clear();

                    RefreshComboBox();
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new ProductInventoryManagementSystemContext())
            {
                try
                {
                    if ((int)comboBoxSelectProductUpdate.SelectedValue == 0)
                    {
                        MessageBox.Show("Please, select a product to update.", "An error occurred whilst updating a product!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var selectedProductId = (int)comboBoxSelectProductUpdate.SelectedValue;

                    var productToUpdate = context.Products.Find(selectedProductId);
                    if (productToUpdate == null)
                    {
                        MessageBox.Show("Product not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string productName = textBoxProductNameUpdate.Text;
                    string category = textBoxCategoryUpdate.Text;
                    decimal price;
                    int stockLevel;

                    if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(category))
                    {
                        MessageBox.Show("Product name and category cannot be empty.", "An error occurred whilst updating a product!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!decimal.TryParse(textBoxPriceUpdate.Text, out price) || price <= 0)
                    {
                        MessageBox.Show("The price must be a positive number and/or higher than 0. Please, try again", "An error occurred whilst updating a product!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!int.TryParse(textBoxStockLevelUpdate.Text, out stockLevel) || stockLevel <= 0)
                    {
                        MessageBox.Show("Enter a valid stock level.", "An error occurred whilst updating a product!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    productToUpdate.ProductName = productName;
                    productToUpdate.Category = category;
                    productToUpdate.Price = price;
                    productToUpdate.StockLevel = stockLevel;

                    context.SaveChanges();
                    MessageBox.Show($"Product '{productName}' updated successfully!", "Successful operation!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshComboBox();
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var row = dataGridViewProduct.Rows[e.RowIndex];
                    int productId = Convert.ToInt32(row.Cells["ProductID"].Value);

                    using (var context = new ProductInventoryManagementSystemContext())
                    {
                        var selectedProduct = context.Products.Find(productId);
                        if (selectedProduct != null)
                        {
                            textBoxProductNameUpdate.Text = selectedProduct.ProductName;
                            textBoxCategoryUpdate.Text = selectedProduct.Category;
                            textBoxPriceUpdate.Text = selectedProduct.Price.ToString();
                            textBoxStockLevelUpdate.Text = selectedProduct.StockLevel.ToString();
                            comboBoxSelectProductUpdate.SelectedValue = selectedProduct.ProductId;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if ((int)comboBoxSelectProductView.SelectedValue == 0)
                {
                    MessageBox.Show("Please, select a product to search.", "An error occurred whilst searching for a product!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var selectedProductId = (int)comboBoxSelectProductView.SelectedValue;

                using (var context = new ProductInventoryManagementSystemContext())
                {
                    var product = context.Products.Find(selectedProductId);
                    if (product != null)
                    {
                        dataGridViewProduct.DataSource = new[] { new { product.ProductId, product.ProductName, product.Category, product.Price, product.StockLevel } };
                    }

                    else
                    {
                        MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxSelectProductUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //AUTOFILL FOR PRODUCTS
            if (comboBoxSelectProductUpdate.SelectedValue != null)
            {
                var selectedProduct = comboBoxSelectProductUpdate.SelectedItem as dynamic;

                if (selectedProduct != null && selectedProduct.ProductId != 0)
                {
                    using (var context = new ProductInventoryManagementSystemContext())
                    {
                        var selectedProductId = selectedProduct.ProductId; // Access the ProductId from the anonymous type
                        var product = context.Products.Find(selectedProductId);

                        if (product != null)
                        {
                            textBoxProductNameUpdate.Text = product.ProductName;
                            textBoxCategoryUpdate.Text = product.Category;
                            textBoxPriceUpdate.Text = product.Price.ToString();
                            textBoxStockLevelUpdate.Text = product.StockLevel.ToString();
                        }
                    }
                }
                else
                {
                    //Clear fields if the placeholder is selected
                    textBoxProductNameUpdate.Clear();
                    textBoxCategoryUpdate.Clear();
                    textBoxPriceUpdate.Clear();
                    textBoxStockLevelUpdate.Clear();
                }
            }
        }

        //SALES MANAGEMENT//
        private void buttonRecord_Click(object sender, EventArgs e)
        {
            using (var context = new ProductInventoryManagementSystemContext())
            {
                try
                {
                    if ((int)comboBoxProduct.SelectedValue == 0 || (int)comboBoxCustomer.SelectedValue == 0)
                    {
                        MessageBox.Show("Please select a product and a customer.", "Error whilst recording a new sale!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int productId = (int)comboBoxProduct.SelectedValue;
                    int customerId = (int)comboBoxCustomer.SelectedValue;
                    int quantitySold;
                    DateTime saleDate = dateTimePickerSaleDate.Value;

                    if (!int.TryParse(textBoxQuantitySold.Text, out quantitySold) || quantitySold <= 0)
                    {
                        MessageBox.Show("Please enter a valid quantity.", "Error whilst recording a new sale!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var product = context.Products.Find(productId);
                    var customer = context.Customers.Find(customerId);

                    if (product == null || customer == null)
                    {
                        MessageBox.Show("Product or customer not found.", "Error whilst recording a new sale!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (product.StockLevel < quantitySold)
                    {
                        MessageBox.Show("Not enough stock available.", "Error whilst recording a new sale!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var sale = new Sale
                    {
                        ProductId = productId,
                        CustomerId = customerId,
                        QuantitySold = quantitySold,
                        SaleDate = saleDate
                    };

                    product.StockLevel -= quantitySold;
                    context.Sales.Add(sale);
                    context.SaveChanges();

                    MessageBox.Show("Sale recorded successfully!", "Successful operation!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadLowStockProducts();
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadLowStockProducts()
        {
            using (var context = new ProductInventoryManagementSystemContext())
            {
                var lowStockProducts = context.Products
                    //Defined threshold
                    .Where(p => p.StockLevel < 10)
                    .Select(p => new
                    {
                        p.ProductId,
                        p.ProductName,
                        p.StockLevel
                    })
                    .ToList();

                dataGridViewLowStockAlert.DataSource = lowStockProducts;

                // Check if there are low-stock (displaying message)
                if (lowStockProducts.Any())
                {
                    MessageBox.Show(
                        "Warning: Some products are running low on stock. Please restock soon.",
                        "Low Stock Alert",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }

        //CUSTOMER MANAGEMENT//
        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            using (var context = new ProductInventoryManagementSystemContext())
            {
                try
                {
                    string customerName = textBoxCustomerNameAdd.Text.Trim();
                    string phoneNumber = textBoxPhoneNumberAdd.Text.Trim();
                    string email = textBoxEmailAdd.Text.Trim();

                    if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(email))
                    {
                        MessageBox.Show("All fields are required.", "Error whilst adding a new customer!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!IsValidPhoneNumber(phoneNumber))
                    {
                        MessageBox.Show("Invalid phone number format.\n(example: (123) 456-7890 or 123-456-7890", "Error whilst adding a customer!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!IsValidEmail(email))
                    {
                        MessageBox.Show("Invalid email format.", "Error whilst adding a new customer!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var newCustomer = new Customer
                    {
                        CustomerName = textBoxCustomerNameAdd.Text,
                        PhoneNumber = textBoxPhoneNumberAdd.Text,
                        Email = textBoxEmailAdd.Text
                    };

                    context.Customers.Add(newCustomer);
                    context.SaveChanges();

                    MessageBox.Show($"Customer '{customerName}' added successfully!", "Successful operation!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Clear fields after saving
                    textBoxCustomerNameAdd.Clear();
                    textBoxPhoneNumberAdd.Clear();
                    textBoxEmailAdd.Clear();

                    RefreshComboBox();
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonUpdateDetails_Click(object sender, EventArgs e)
        {
            using (var context = new ProductInventoryManagementSystemContext())
            {
                try
                {
                    if ((int)comboBoxSelectCustomer.SelectedValue == 0)
                    {
                        MessageBox.Show("Please, select a customer to update.", "An error occurred whilst updating a customer!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var selectedCustomerId = (int)comboBoxSelectCustomer.SelectedValue;

                    var customerToUpdate = context.Customers.Find(selectedCustomerId);
                    if (customerToUpdate == null)
                    {
                        MessageBox.Show("Customer not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string customerName = textBoxCustomerNameUpdate.Text.Trim();
                    string phoneNumber = textBoxPhoneNumberUpdate.Text.Trim();
                    string email = textBoxEmailUpdate.Text.Trim();

                    if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(email))
                    {
                        MessageBox.Show("Customer name, phone number, and email cannot be empty.", "An error occurred whilst updating a customer!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!IsValidPhoneNumber(phoneNumber))
                    {
                        MessageBox.Show("Invalid phone number format.", "Error whilst updating a customer!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!IsValidEmail(email))
                    {
                        MessageBox.Show("Invalid email format.\n(example: (123) 456-7890 or 123-456-7890", "Error whilst updating a customer!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    customerToUpdate.CustomerName = customerName;
                    customerToUpdate.PhoneNumber = phoneNumber;
                    customerToUpdate.Email = email;

                    context.SaveChanges();
                    MessageBox.Show($"Product '{customerName}' updated successfully!", "Successful operation!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshComboBox();
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using (var context = new ProductInventoryManagementSystemContext())
            {
                try
                {
                    if ((int)comboBoxSelectCustomerDelete.SelectedValue == 0)
                    {
                        MessageBox.Show("Please, select a customer to delete.", "Error whilst deleting a customer!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var selectedCustomerId = (int)comboBoxSelectCustomerDelete.SelectedValue;

                    var customerToDelete = context.Customers.Find(selectedCustomerId);
                    if (customerToDelete == null)
                    {
                        MessageBox.Show("Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var confirmDeletion = MessageBox.Show($"Are you sure you want to delete customer '{customerToDelete.CustomerName}' and all associated sales?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmDeletion == DialogResult.Yes)
                    {
                        // Delete the customer (cascade will handle sales deletion)
                        context.Customers.Remove(customerToDelete);
                        context.SaveChanges();

                        MessageBox.Show("Customer and associated sales deleted successfully!", "Successful operation!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the ComboBox
                        RefreshComboBox();
                    }

                    else
                    {
                        MessageBox.Show("Deletion cancelled.", "Error whilst deleting a customer!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //(Email Validation)
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        //(Phone Number Validation)
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Define a pattern for the number (example: (123) 456-7890 or 123-456-7890)
            var phoneRegex = new System.Text.RegularExpressions.Regex(@"^(\(\d{3}\)\s?|\d{3}-)\d{3}-\d{4}$");

            return phoneRegex.IsMatch(phoneNumber);
        }


        //AUTOFILL FOR CUSTOMER
        private void comboBoxSelectCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectCustomer.SelectedValue != null)
            {
                var selectedCustomer = comboBoxSelectCustomer.SelectedItem as dynamic;

                if (selectedCustomer != null && selectedCustomer.CustomerId != 0)
                {
                    using (var context = new ProductInventoryManagementSystemContext())
                    {
                        var selectedCustomerId = selectedCustomer.CustomerId; // Access the ProductId from the anonymous type
                        var customer = context.Customers.Find(selectedCustomerId);

                        if (customer != null)
                        {
                            textBoxCustomerNameUpdate.Text = customer.CustomerName;
                            textBoxPhoneNumberUpdate.Text = customer.PhoneNumber;
                            textBoxEmailUpdate.Text = customer.Email;
                        }
                    }
                }
                else
                {
                    //Clear fields if the placeholder is selected
                    textBoxCustomerNameUpdate.Clear();
                    textBoxPhoneNumberUpdate.Clear();
                    textBoxEmailUpdate.Clear();
                }
            }
        }

        private void RefreshComboBox()
        {
            //TO SEE THE UPDATED COMBOBOXES
            using (var context = new ProductInventoryManagementSystemContext())
            {
                //Products
                var products = context.Products.Select(p => new
                {
                    p.ProductId,
                    p.ProductName
                }).ToList();

                //Placeholder
                var placeholder = new { ProductId = 0, ProductName = "Select your product:" };
                products.Insert(0, placeholder);

                // Rebind the ComboBox with updated data
                comboBoxSelectProductUpdate.DataSource = products;
                comboBoxSelectProductUpdate.DisplayMember = "ProductName";
                comboBoxSelectProductUpdate.ValueMember = "ProductId";

                comboBoxSelectProductView.DataSource = products;
                comboBoxSelectProductView.DisplayMember = "ProductName";
                comboBoxSelectProductView.ValueMember = "ProductId";

                comboBoxProduct.DataSource = products;
                comboBoxProduct.DisplayMember = "ProductName";
                comboBoxProduct.ValueMember = "ProductID";

                //Customers
                var customers = context.Customers.Select(c => new
                {
                    c.CustomerId,
                    c.CustomerName
                }).ToList();

                var placeholderCustomer = new { CustomerId = 0, CustomerName = "Select your customer:" };
                customers.Insert(0, placeholderCustomer);

                comboBoxCustomer.DataSource = customers;
                comboBoxCustomer.DisplayMember = "CustomerName";
                comboBoxCustomer.ValueMember = "CustomerID";

                comboBoxSelectCustomer.DataSource = customers;
                comboBoxSelectCustomer.DisplayMember = "CustomerName";
                comboBoxSelectCustomer.ValueMember = "CustomerID";

                comboBoxSelectCustomerDelete.DataSource = customers;
                comboBoxSelectCustomerDelete.DisplayMember = "CustomerName";
                comboBoxSelectCustomerDelete.ValueMember = "CustomerID";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new ProductInventoryManagementSystemContext())
            {
                //Populate product comboboxes in the form
                var products = context.Products.Select(p => new
                {
                    p.ProductId,
                    p.ProductName
                }).ToList();

                //PLACEHOLDER (to ensure good error handling)
                var placeholder = new { ProductId = 0, ProductName = "Select your product:" };
                products.Insert(0, placeholder);

                comboBoxSelectProductUpdate.DataSource = products;
                comboBoxSelectProductUpdate.DisplayMember = "ProductName";
                comboBoxSelectProductUpdate.ValueMember = "ProductID";

                comboBoxSelectProductView.DataSource = products;
                comboBoxSelectProductView.DisplayMember = "ProductName";
                comboBoxSelectProductView.ValueMember = "ProductID";

                comboBoxProduct.DataSource = products;
                comboBoxProduct.DisplayMember = "ProductName";
                comboBoxProduct.ValueMember = "ProductID";

                //Populate customer comboboxes in the form
                var customers = context.Customers.Select(c => new
                {
                    c.CustomerId,
                    c.CustomerName
                }).ToList();

                //PLACEHOLDER (to ensure good error handling)
                var placeholderCustomer = new { CustomerId = 0, CustomerName = "Select your customer:" };
                customers.Insert(0, placeholderCustomer);

                comboBoxCustomer.DataSource = customers;
                comboBoxCustomer.DisplayMember = "CustomerName";
                comboBoxCustomer.ValueMember = "CustomerID";

                comboBoxSelectCustomer.DataSource = customers;
                comboBoxSelectCustomer.DisplayMember = "CustomerName";
                comboBoxSelectCustomer.ValueMember = "CustomerID";

                comboBoxSelectCustomerDelete.DataSource = customers;
                comboBoxSelectCustomerDelete.DisplayMember = "CustomerName";
                comboBoxSelectCustomerDelete.ValueMember = "CustomerID";
            }
            LoadLowStockProducts();
        }
    }
}