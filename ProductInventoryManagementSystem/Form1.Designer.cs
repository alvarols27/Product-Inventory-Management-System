namespace ProductInventoryManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabCustomerManagement = new TabPage();
            groupBoxDeleteCustomer = new GroupBox();
            buttonDelete = new Button();
            comboBoxSelectCustomerDelete = new ComboBox();
            label15 = new Label();
            groupBoxUpdateCustomer = new GroupBox();
            comboBoxSelectCustomer = new ComboBox();
            label16 = new Label();
            buttonUpdateDetails = new Button();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            textBoxEmailUpdate = new TextBox();
            textBoxPhoneNumberUpdate = new TextBox();
            textBoxCustomerNameUpdate = new TextBox();
            groupBoxAddCustomer = new GroupBox();
            buttonAddCustomer = new Button();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            textBoxEmailAdd = new TextBox();
            textBoxPhoneNumberAdd = new TextBox();
            textBoxCustomerNameAdd = new TextBox();
            tabSalesManagement = new TabPage();
            groupBoxLowStockAlert = new GroupBox();
            dataGridViewLowStockAlert = new DataGridView();
            groupBoxRecordSales = new GroupBox();
            dateTimePickerSaleDate = new DateTimePicker();
            comboBoxCustomer = new ComboBox();
            comboBoxProduct = new ComboBox();
            buttonRecord = new Button();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            textBoxQuantitySold = new TextBox();
            tabProductManagement = new TabPage();
            groupBoxViewProductDetails = new GroupBox();
            buttonSearch = new Button();
            dataGridViewProduct = new DataGridView();
            comboBoxSelectProductView = new ComboBox();
            label10 = new Label();
            groupBoxUpdateProduct = new GroupBox();
            comboBoxSelectProductUpdate = new ComboBox();
            label9 = new Label();
            buttonUpdate = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxStockLevelUpdate = new TextBox();
            textBoxPriceUpdate = new TextBox();
            textBoxCategoryUpdate = new TextBox();
            textBoxProductNameUpdate = new TextBox();
            groupBoxAddProduct = new GroupBox();
            buttonSave = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxStockLevelAdd = new TextBox();
            textBoxPriceAdd = new TextBox();
            textBoxCategoryAdd = new TextBox();
            textBoxProductNameAdd = new TextBox();
            tabControl1.SuspendLayout();
            tabCustomerManagement.SuspendLayout();
            groupBoxDeleteCustomer.SuspendLayout();
            groupBoxUpdateCustomer.SuspendLayout();
            groupBoxAddCustomer.SuspendLayout();
            tabSalesManagement.SuspendLayout();
            groupBoxLowStockAlert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLowStockAlert).BeginInit();
            groupBoxRecordSales.SuspendLayout();
            tabProductManagement.SuspendLayout();
            groupBoxViewProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            groupBoxUpdateProduct.SuspendLayout();
            groupBoxAddProduct.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCustomerManagement);
            tabControl1.Controls.Add(tabSalesManagement);
            tabControl1.Controls.Add(tabProductManagement);
            tabControl1.Location = new Point(1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1152, 711);
            tabControl1.TabIndex = 0;
            // 
            // tabCustomerManagement
            // 
            tabCustomerManagement.Controls.Add(groupBoxDeleteCustomer);
            tabCustomerManagement.Controls.Add(groupBoxUpdateCustomer);
            tabCustomerManagement.Controls.Add(groupBoxAddCustomer);
            tabCustomerManagement.Location = new Point(4, 39);
            tabCustomerManagement.Name = "tabCustomerManagement";
            tabCustomerManagement.Padding = new Padding(3);
            tabCustomerManagement.Size = new Size(1144, 668);
            tabCustomerManagement.TabIndex = 0;
            tabCustomerManagement.Text = "Customer Management";
            tabCustomerManagement.UseVisualStyleBackColor = true;
            // 
            // groupBoxDeleteCustomer
            // 
            groupBoxDeleteCustomer.Controls.Add(buttonDelete);
            groupBoxDeleteCustomer.Controls.Add(comboBoxSelectCustomerDelete);
            groupBoxDeleteCustomer.Controls.Add(label15);
            groupBoxDeleteCustomer.Location = new Point(7, 346);
            groupBoxDeleteCustomer.Name = "groupBoxDeleteCustomer";
            groupBoxDeleteCustomer.Size = new Size(1131, 319);
            groupBoxDeleteCustomer.TabIndex = 7;
            groupBoxDeleteCustomer.TabStop = false;
            groupBoxDeleteCustomer.Text = "Delete Customer";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(515, 196);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(131, 40);
            buttonDelete.TabIndex = 23;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // comboBoxSelectCustomerDelete
            // 
            comboBoxSelectCustomerDelete.FormattingEnabled = true;
            comboBoxSelectCustomerDelete.Location = new Point(609, 107);
            comboBoxSelectCustomerDelete.Name = "comboBoxSelectCustomerDelete";
            comboBoxSelectCustomerDelete.Size = new Size(231, 38);
            comboBoxSelectCustomerDelete.TabIndex = 21;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(403, 110);
            label15.Name = "label15";
            label15.Size = new Size(163, 30);
            label15.TabIndex = 20;
            label15.Text = "Select Customer";
            // 
            // groupBoxUpdateCustomer
            // 
            groupBoxUpdateCustomer.Controls.Add(comboBoxSelectCustomer);
            groupBoxUpdateCustomer.Controls.Add(label16);
            groupBoxUpdateCustomer.Controls.Add(buttonUpdateDetails);
            groupBoxUpdateCustomer.Controls.Add(label18);
            groupBoxUpdateCustomer.Controls.Add(label19);
            groupBoxUpdateCustomer.Controls.Add(label20);
            groupBoxUpdateCustomer.Controls.Add(textBoxEmailUpdate);
            groupBoxUpdateCustomer.Controls.Add(textBoxPhoneNumberUpdate);
            groupBoxUpdateCustomer.Controls.Add(textBoxCustomerNameUpdate);
            groupBoxUpdateCustomer.Location = new Point(551, 3);
            groupBoxUpdateCustomer.Name = "groupBoxUpdateCustomer";
            groupBoxUpdateCustomer.Size = new Size(587, 337);
            groupBoxUpdateCustomer.TabIndex = 6;
            groupBoxUpdateCustomer.TabStop = false;
            groupBoxUpdateCustomer.Text = "Update Customer";
            // 
            // comboBoxSelectCustomer
            // 
            comboBoxSelectCustomer.FormattingEnabled = true;
            comboBoxSelectCustomer.Location = new Point(285, 45);
            comboBoxSelectCustomer.Name = "comboBoxSelectCustomer";
            comboBoxSelectCustomer.Size = new Size(212, 38);
            comboBoxSelectCustomer.TabIndex = 19;
            comboBoxSelectCustomer.SelectedIndexChanged += comboBoxSelectCustomer_SelectedIndexChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(96, 53);
            label16.Name = "label16";
            label16.Size = new Size(163, 30);
            label16.TabIndex = 18;
            label16.Text = "Select Customer";
            // 
            // buttonUpdateDetails
            // 
            buttonUpdateDetails.Location = new Point(181, 250);
            buttonUpdateDetails.Name = "buttonUpdateDetails";
            buttonUpdateDetails.Size = new Size(209, 40);
            buttonUpdateDetails.TabIndex = 17;
            buttonUpdateDetails.Text = "Update Details";
            buttonUpdateDetails.UseVisualStyleBackColor = true;
            buttonUpdateDetails.Click += buttonUpdateDetails_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(96, 191);
            label18.Name = "label18";
            label18.Size = new Size(63, 30);
            label18.TabIndex = 15;
            label18.Text = "Email";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(96, 145);
            label19.Name = "label19";
            label19.Size = new Size(154, 30);
            label19.TabIndex = 14;
            label19.Text = "Phone Number";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(96, 97);
            label20.Name = "label20";
            label20.Size = new Size(164, 30);
            label20.TabIndex = 13;
            label20.Text = "Customer Name";
            // 
            // textBoxEmailUpdate
            // 
            textBoxEmailUpdate.Location = new Point(285, 186);
            textBoxEmailUpdate.Name = "textBoxEmailUpdate";
            textBoxEmailUpdate.Size = new Size(212, 35);
            textBoxEmailUpdate.TabIndex = 11;
            // 
            // textBoxPhoneNumberUpdate
            // 
            textBoxPhoneNumberUpdate.Location = new Point(285, 140);
            textBoxPhoneNumberUpdate.Name = "textBoxPhoneNumberUpdate";
            textBoxPhoneNumberUpdate.Size = new Size(212, 35);
            textBoxPhoneNumberUpdate.TabIndex = 10;
            // 
            // textBoxCustomerNameUpdate
            // 
            textBoxCustomerNameUpdate.Location = new Point(285, 92);
            textBoxCustomerNameUpdate.Name = "textBoxCustomerNameUpdate";
            textBoxCustomerNameUpdate.Size = new Size(212, 35);
            textBoxCustomerNameUpdate.TabIndex = 9;
            // 
            // groupBoxAddCustomer
            // 
            groupBoxAddCustomer.Controls.Add(buttonAddCustomer);
            groupBoxAddCustomer.Controls.Add(label22);
            groupBoxAddCustomer.Controls.Add(label23);
            groupBoxAddCustomer.Controls.Add(label24);
            groupBoxAddCustomer.Controls.Add(textBoxEmailAdd);
            groupBoxAddCustomer.Controls.Add(textBoxPhoneNumberAdd);
            groupBoxAddCustomer.Controls.Add(textBoxCustomerNameAdd);
            groupBoxAddCustomer.Location = new Point(7, 3);
            groupBoxAddCustomer.Name = "groupBoxAddCustomer";
            groupBoxAddCustomer.Size = new Size(538, 337);
            groupBoxAddCustomer.TabIndex = 5;
            groupBoxAddCustomer.TabStop = false;
            groupBoxAddCustomer.Text = "Add Customer";
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.Location = new Point(137, 250);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new Size(202, 40);
            buttonAddCustomer.TabIndex = 8;
            buttonAddCustomer.Text = "Add Customer";
            buttonAddCustomer.UseVisualStyleBackColor = true;
            buttonAddCustomer.Click += buttonAddCustomer_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(64, 177);
            label22.Name = "label22";
            label22.Size = new Size(63, 30);
            label22.TabIndex = 6;
            label22.Text = "Email";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(64, 131);
            label23.Name = "label23";
            label23.Size = new Size(154, 30);
            label23.TabIndex = 5;
            label23.Text = "Phone Number";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(64, 83);
            label24.Name = "label24";
            label24.Size = new Size(164, 30);
            label24.TabIndex = 4;
            label24.Text = "Customer Name";
            // 
            // textBoxEmailAdd
            // 
            textBoxEmailAdd.Location = new Point(245, 177);
            textBoxEmailAdd.Name = "textBoxEmailAdd";
            textBoxEmailAdd.Size = new Size(207, 35);
            textBoxEmailAdd.TabIndex = 2;
            // 
            // textBoxPhoneNumberAdd
            // 
            textBoxPhoneNumberAdd.Location = new Point(245, 128);
            textBoxPhoneNumberAdd.Name = "textBoxPhoneNumberAdd";
            textBoxPhoneNumberAdd.Size = new Size(207, 35);
            textBoxPhoneNumberAdd.TabIndex = 1;
            // 
            // textBoxCustomerNameAdd
            // 
            textBoxCustomerNameAdd.Location = new Point(245, 78);
            textBoxCustomerNameAdd.Name = "textBoxCustomerNameAdd";
            textBoxCustomerNameAdd.Size = new Size(207, 35);
            textBoxCustomerNameAdd.TabIndex = 0;
            // 
            // tabSalesManagement
            // 
            tabSalesManagement.Controls.Add(groupBoxLowStockAlert);
            tabSalesManagement.Controls.Add(groupBoxRecordSales);
            tabSalesManagement.Location = new Point(4, 39);
            tabSalesManagement.Name = "tabSalesManagement";
            tabSalesManagement.Padding = new Padding(3);
            tabSalesManagement.Size = new Size(1141, 668);
            tabSalesManagement.TabIndex = 1;
            tabSalesManagement.Text = "Sales Management";
            tabSalesManagement.UseVisualStyleBackColor = true;
            // 
            // groupBoxLowStockAlert
            // 
            groupBoxLowStockAlert.Controls.Add(dataGridViewLowStockAlert);
            groupBoxLowStockAlert.Location = new Point(33, 328);
            groupBoxLowStockAlert.Name = "groupBoxLowStockAlert";
            groupBoxLowStockAlert.Size = new Size(1080, 337);
            groupBoxLowStockAlert.TabIndex = 24;
            groupBoxLowStockAlert.TabStop = false;
            groupBoxLowStockAlert.Text = "LowStockAlert";
            // 
            // dataGridViewLowStockAlert
            // 
            dataGridViewLowStockAlert.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLowStockAlert.Location = new Point(6, 47);
            dataGridViewLowStockAlert.Name = "dataGridViewLowStockAlert";
            dataGridViewLowStockAlert.RowHeadersWidth = 72;
            dataGridViewLowStockAlert.Size = new Size(1068, 283);
            dataGridViewLowStockAlert.TabIndex = 23;
            // 
            // groupBoxRecordSales
            // 
            groupBoxRecordSales.Controls.Add(dateTimePickerSaleDate);
            groupBoxRecordSales.Controls.Add(comboBoxCustomer);
            groupBoxRecordSales.Controls.Add(comboBoxProduct);
            groupBoxRecordSales.Controls.Add(buttonRecord);
            groupBoxRecordSales.Controls.Add(label11);
            groupBoxRecordSales.Controls.Add(label12);
            groupBoxRecordSales.Controls.Add(label13);
            groupBoxRecordSales.Controls.Add(label14);
            groupBoxRecordSales.Controls.Add(textBoxQuantitySold);
            groupBoxRecordSales.Location = new Point(33, 6);
            groupBoxRecordSales.Name = "groupBoxRecordSales";
            groupBoxRecordSales.Size = new Size(1080, 316);
            groupBoxRecordSales.TabIndex = 23;
            groupBoxRecordSales.TabStop = false;
            groupBoxRecordSales.Text = "Record Sales";
            // 
            // dateTimePickerSaleDate
            // 
            dateTimePickerSaleDate.Location = new Point(516, 180);
            dateTimePickerSaleDate.Name = "dateTimePickerSaleDate";
            dateTimePickerSaleDate.Size = new Size(246, 35);
            dateTimePickerSaleDate.TabIndex = 20;
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(516, 85);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(246, 38);
            comboBoxCustomer.TabIndex = 19;
            // 
            // comboBoxProduct
            // 
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Location = new Point(516, 37);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(246, 38);
            comboBoxProduct.TabIndex = 18;
            // 
            // buttonRecord
            // 
            buttonRecord.Location = new Point(578, 240);
            buttonRecord.Name = "buttonRecord";
            buttonRecord.Size = new Size(131, 40);
            buttonRecord.TabIndex = 17;
            buttonRecord.Text = "Record";
            buttonRecord.UseVisualStyleBackColor = true;
            buttonRecord.Click += buttonRecord_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(357, 185);
            label11.Name = "label11";
            label11.Size = new Size(101, 30);
            label11.TabIndex = 16;
            label11.Text = "Sale Date";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(357, 137);
            label12.Name = "label12";
            label12.Size = new Size(139, 30);
            label12.TabIndex = 15;
            label12.Text = "Quantity Sold";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(357, 88);
            label13.Name = "label13";
            label13.Size = new Size(102, 30);
            label13.TabIndex = 14;
            label13.Text = "Customer";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(357, 40);
            label14.Name = "label14";
            label14.Size = new Size(85, 30);
            label14.TabIndex = 13;
            label14.Text = "Product";
            // 
            // textBoxQuantitySold
            // 
            textBoxQuantitySold.Location = new Point(516, 134);
            textBoxQuantitySold.Name = "textBoxQuantitySold";
            textBoxQuantitySold.Size = new Size(246, 35);
            textBoxQuantitySold.TabIndex = 11;
            // 
            // tabProductManagement
            // 
            tabProductManagement.Controls.Add(groupBoxViewProductDetails);
            tabProductManagement.Controls.Add(groupBoxUpdateProduct);
            tabProductManagement.Controls.Add(groupBoxAddProduct);
            tabProductManagement.Location = new Point(4, 39);
            tabProductManagement.Name = "tabProductManagement";
            tabProductManagement.Padding = new Padding(3);
            tabProductManagement.Size = new Size(1141, 668);
            tabProductManagement.TabIndex = 2;
            tabProductManagement.Text = "Product Management";
            tabProductManagement.UseVisualStyleBackColor = true;
            // 
            // groupBoxViewProductDetails
            // 
            groupBoxViewProductDetails.Controls.Add(buttonSearch);
            groupBoxViewProductDetails.Controls.Add(dataGridViewProduct);
            groupBoxViewProductDetails.Controls.Add(comboBoxSelectProductView);
            groupBoxViewProductDetails.Controls.Add(label10);
            groupBoxViewProductDetails.Location = new Point(7, 348);
            groupBoxViewProductDetails.Name = "groupBoxViewProductDetails";
            groupBoxViewProductDetails.Size = new Size(1131, 317);
            groupBoxViewProductDetails.TabIndex = 4;
            groupBoxViewProductDetails.TabStop = false;
            groupBoxViewProductDetails.Text = "View Product Details";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(504, 43);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(131, 40);
            buttonSearch.TabIndex = 23;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Location = new Point(6, 98);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.RowHeadersWidth = 72;
            dataGridViewProduct.Size = new Size(1119, 219);
            dataGridViewProduct.TabIndex = 22;
            dataGridViewProduct.CellContentClick += dataGridViewProduct_CellContentClick;
            // 
            // comboBoxSelectProductView
            // 
            comboBoxSelectProductView.FormattingEnabled = true;
            comboBoxSelectProductView.Location = new Point(212, 45);
            comboBoxSelectProductView.Name = "comboBoxSelectProductView";
            comboBoxSelectProductView.Size = new Size(231, 38);
            comboBoxSelectProductView.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(53, 45);
            label10.Name = "label10";
            label10.Size = new Size(146, 30);
            label10.TabIndex = 20;
            label10.Text = "Select Product";
            // 
            // groupBoxUpdateProduct
            // 
            groupBoxUpdateProduct.Controls.Add(comboBoxSelectProductUpdate);
            groupBoxUpdateProduct.Controls.Add(label9);
            groupBoxUpdateProduct.Controls.Add(buttonUpdate);
            groupBoxUpdateProduct.Controls.Add(label5);
            groupBoxUpdateProduct.Controls.Add(label6);
            groupBoxUpdateProduct.Controls.Add(label7);
            groupBoxUpdateProduct.Controls.Add(label8);
            groupBoxUpdateProduct.Controls.Add(textBoxStockLevelUpdate);
            groupBoxUpdateProduct.Controls.Add(textBoxPriceUpdate);
            groupBoxUpdateProduct.Controls.Add(textBoxCategoryUpdate);
            groupBoxUpdateProduct.Controls.Add(textBoxProductNameUpdate);
            groupBoxUpdateProduct.Location = new Point(551, 5);
            groupBoxUpdateProduct.Name = "groupBoxUpdateProduct";
            groupBoxUpdateProduct.Size = new Size(587, 337);
            groupBoxUpdateProduct.TabIndex = 3;
            groupBoxUpdateProduct.TabStop = false;
            groupBoxUpdateProduct.Text = "Update Product";
            // 
            // comboBoxSelectProductUpdate
            // 
            comboBoxSelectProductUpdate.FormattingEnabled = true;
            comboBoxSelectProductUpdate.Location = new Point(255, 45);
            comboBoxSelectProductUpdate.Name = "comboBoxSelectProductUpdate";
            comboBoxSelectProductUpdate.Size = new Size(212, 38);
            comboBoxSelectProductUpdate.TabIndex = 19;
            comboBoxSelectProductUpdate.SelectedIndexChanged += comboBoxSelectProductUpdate_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(96, 53);
            label9.Name = "label9";
            label9.Size = new Size(146, 30);
            label9.TabIndex = 18;
            label9.Text = "Select Product";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(299, 291);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(131, 40);
            buttonUpdate.TabIndex = 17;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 236);
            label5.Name = "label5";
            label5.Size = new Size(115, 30);
            label5.TabIndex = 16;
            label5.Text = "Stock Level";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 191);
            label6.Name = "label6";
            label6.Size = new Size(58, 30);
            label6.TabIndex = 15;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(96, 145);
            label7.Name = "label7";
            label7.Size = new Size(96, 30);
            label7.TabIndex = 14;
            label7.Text = "Category";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(96, 97);
            label8.Name = "label8";
            label8.Size = new Size(147, 30);
            label8.TabIndex = 13;
            label8.Text = "Product Name";
            // 
            // textBoxStockLevelUpdate
            // 
            textBoxStockLevelUpdate.Location = new Point(255, 236);
            textBoxStockLevelUpdate.Name = "textBoxStockLevelUpdate";
            textBoxStockLevelUpdate.Size = new Size(212, 35);
            textBoxStockLevelUpdate.TabIndex = 12;
            // 
            // textBoxPriceUpdate
            // 
            textBoxPriceUpdate.Location = new Point(255, 186);
            textBoxPriceUpdate.Name = "textBoxPriceUpdate";
            textBoxPriceUpdate.Size = new Size(212, 35);
            textBoxPriceUpdate.TabIndex = 11;
            // 
            // textBoxCategoryUpdate
            // 
            textBoxCategoryUpdate.Location = new Point(255, 140);
            textBoxCategoryUpdate.Name = "textBoxCategoryUpdate";
            textBoxCategoryUpdate.Size = new Size(212, 35);
            textBoxCategoryUpdate.TabIndex = 10;
            // 
            // textBoxProductNameUpdate
            // 
            textBoxProductNameUpdate.Location = new Point(255, 92);
            textBoxProductNameUpdate.Name = "textBoxProductNameUpdate";
            textBoxProductNameUpdate.Size = new Size(212, 35);
            textBoxProductNameUpdate.TabIndex = 9;
            // 
            // groupBoxAddProduct
            // 
            groupBoxAddProduct.Controls.Add(buttonSave);
            groupBoxAddProduct.Controls.Add(label4);
            groupBoxAddProduct.Controls.Add(label3);
            groupBoxAddProduct.Controls.Add(label2);
            groupBoxAddProduct.Controls.Add(label1);
            groupBoxAddProduct.Controls.Add(textBoxStockLevelAdd);
            groupBoxAddProduct.Controls.Add(textBoxPriceAdd);
            groupBoxAddProduct.Controls.Add(textBoxCategoryAdd);
            groupBoxAddProduct.Controls.Add(textBoxProductNameAdd);
            groupBoxAddProduct.Location = new Point(7, 5);
            groupBoxAddProduct.Name = "groupBoxAddProduct";
            groupBoxAddProduct.Size = new Size(538, 337);
            groupBoxAddProduct.TabIndex = 2;
            groupBoxAddProduct.TabStop = false;
            groupBoxAddProduct.Text = "Add Product";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(249, 263);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(131, 40);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 206);
            label4.Name = "label4";
            label4.Size = new Size(115, 30);
            label4.TabIndex = 7;
            label4.Text = "Stock Level";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 156);
            label3.Name = "label3";
            label3.Size = new Size(58, 30);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 110);
            label2.Name = "label2";
            label2.Size = new Size(96, 30);
            label2.TabIndex = 5;
            label2.Text = "Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 62);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 4;
            label1.Text = "Product Name";
            // 
            // textBoxStockLevelAdd
            // 
            textBoxStockLevelAdd.Location = new Point(212, 206);
            textBoxStockLevelAdd.Name = "textBoxStockLevelAdd";
            textBoxStockLevelAdd.Size = new Size(207, 35);
            textBoxStockLevelAdd.TabIndex = 3;
            // 
            // textBoxPriceAdd
            // 
            textBoxPriceAdd.Location = new Point(212, 156);
            textBoxPriceAdd.Name = "textBoxPriceAdd";
            textBoxPriceAdd.Size = new Size(207, 35);
            textBoxPriceAdd.TabIndex = 2;
            // 
            // textBoxCategoryAdd
            // 
            textBoxCategoryAdd.Location = new Point(212, 107);
            textBoxCategoryAdd.Name = "textBoxCategoryAdd";
            textBoxCategoryAdd.Size = new Size(207, 35);
            textBoxCategoryAdd.TabIndex = 1;
            // 
            // textBoxProductNameAdd
            // 
            textBoxProductNameAdd.Location = new Point(212, 57);
            textBoxProductNameAdd.Name = "textBoxProductNameAdd";
            textBoxProductNameAdd.Size = new Size(207, 35);
            textBoxProductNameAdd.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 711);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabCustomerManagement.ResumeLayout(false);
            groupBoxDeleteCustomer.ResumeLayout(false);
            groupBoxDeleteCustomer.PerformLayout();
            groupBoxUpdateCustomer.ResumeLayout(false);
            groupBoxUpdateCustomer.PerformLayout();
            groupBoxAddCustomer.ResumeLayout(false);
            groupBoxAddCustomer.PerformLayout();
            tabSalesManagement.ResumeLayout(false);
            groupBoxLowStockAlert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLowStockAlert).EndInit();
            groupBoxRecordSales.ResumeLayout(false);
            groupBoxRecordSales.PerformLayout();
            tabProductManagement.ResumeLayout(false);
            groupBoxViewProductDetails.ResumeLayout(false);
            groupBoxViewProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            groupBoxUpdateProduct.ResumeLayout(false);
            groupBoxUpdateProduct.PerformLayout();
            groupBoxAddProduct.ResumeLayout(false);
            groupBoxAddProduct.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabCustomerManagement;
        private TabPage tabSalesManagement;
        private TabPage tabProductManagement;
        private GroupBox groupBoxViewProductDetails;
        private GroupBox groupBoxUpdateProduct;
        private ComboBox comboBoxSelectProductUpdate;
        private Label label9;
        private Button buttonUpdate;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxStockLevelUpdate;
        private TextBox textBoxPriceUpdate;
        private TextBox textBoxCategoryUpdate;
        private TextBox textBoxProductNameUpdate;
        private GroupBox groupBoxAddProduct;
        private Button buttonSave;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxStockLevelAdd;
        private TextBox textBoxPriceAdd;
        private TextBox textBoxCategoryAdd;
        private TextBox textBoxProductNameAdd;
        private ComboBox comboBoxSelectProductView;
        private Label label10;
        private Button buttonSearch;
        private DataGridView dataGridViewProduct;
        private GroupBox groupBoxRecordSales;
        private DateTimePicker dateTimePickerSaleDate;
        private ComboBox comboBoxCustomer;
        private ComboBox comboBoxProduct;
        private Button buttonRecord;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textBoxQuantitySold;
        private GroupBox groupBoxDeleteCustomer;
        private Button buttonDelete;
        private ComboBox comboBoxSelectCustomerDelete;
        private Label label15;
        private GroupBox groupBoxUpdateCustomer;
        private ComboBox comboBoxSelectCustomer;
        private Label label16;
        private Button buttonUpdateDetails;
        private Label label18;
        private Label label19;
        private Label label20;
        private TextBox textBoxEmailUpdate;
        private TextBox textBoxPhoneNumberUpdate;
        private TextBox textBoxCustomerNameUpdate;
        private GroupBox groupBoxAddCustomer;
        private Button buttonAddCustomer;
        private Label label22;
        private Label label23;
        private Label label24;
        private TextBox textBoxEmailAdd;
        private TextBox textBoxPhoneNumberAdd;
        private TextBox textBoxCustomerNameAdd;
        private GroupBox groupBoxLowStockAlert;
        private DataGridView dataGridViewLowStockAlert;
    }
}
