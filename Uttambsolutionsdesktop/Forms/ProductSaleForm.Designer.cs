using System;
using System.Drawing;
using System.Windows.Forms;

namespace Uttambsolutionsdesktop.Forms
{
    partial class ProductSaleForm
    {
        public ProductSaleForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            btnCancel = new Button();
            btnAddOrder = new Button();
            dataGridViewProducts = new DataGridView();
            lblProductName = new Label();
            lblProductSaleQuantity = new Label();
            lblSaleTotal = new Label();
            txtSaleTotal = new TextBox();
            dataGridViewProductSales = new DataGridView();
            txtProductSaleQuantity = new TextBox();
            lblProductPrice = new Label();
            txtProductVat = new TextBox();
            lblProductVat = new Label();
            txtProductPrice = new TextBox();
            txtProductName = new TextBox();
            txtProductId = new TextBox();
            btnSearchProduct = new Button();
            txtSearchProduct = new TextBox();
            txtSearchSale = new TextBox();
            btnSearchSale = new Button();
            btnPrintReciept = new Button();
            lblVatTotal = new Label();
            txtVatTotal = new TextBox();
            dataGridView1 = new DataGridView();
            btnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 21);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(229, 25);
            label1.TabIndex = 0;
            label1.Text = "PRODUCT SALES LIST";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1065, 59);
            panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(869, 178);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 38);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(681, 178);
            btnAddOrder.Margin = new Padding(4, 3, 4, 3);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(120, 38);
            btnAddOrder.TabIndex = 14;
            btnAddOrder.Text = "Add";
            btnAddOrder.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.Location = new Point(14, 97);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(596, 119);
            dataGridViewProducts.TabIndex = 2;
            // 
            // lblProductName
            // 
            lblProductName.Location = new Point(627, 65);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(100, 23);
            lblProductName.TabIndex = 17;
            lblProductName.Text = "Product Name:";
            // 
            // lblProductSaleQuantity
            // 
            lblProductSaleQuantity.Location = new Point(627, 123);
            lblProductSaleQuantity.Name = "lblProductSaleQuantity";
            lblProductSaleQuantity.Size = new Size(100, 23);
            lblProductSaleQuantity.TabIndex = 18;
            lblProductSaleQuantity.Text = "Quantity:";
            // 
            // lblSaleTotal
            // 
            lblSaleTotal.Location = new Point(807, 123);
            lblSaleTotal.Name = "lblSaleTotal";
            lblSaleTotal.Size = new Size(66, 23);
            lblSaleTotal.TabIndex = 20;
            lblSaleTotal.Text = "Total:";
            // 
            // txtSaleTotal
            // 
            txtSaleTotal.Location = new Point(807, 149);
            txtSaleTotal.Name = "txtSaleTotal";
            txtSaleTotal.ReadOnly = true;
            txtSaleTotal.Size = new Size(136, 23);
            txtSaleTotal.TabIndex = 21;
            // 
            // dataGridViewProductSales
            // 
            dataGridViewProductSales.Location = new Point(14, 264);
            dataGridViewProductSales.Name = "dataGridViewProductSales";
            dataGridViewProductSales.Size = new Size(596, 221);
            dataGridViewProductSales.TabIndex = 22;
            // 
            // txtProductSaleQuantity
            // 
            txtProductSaleQuantity.Location = new Point(627, 149);
            txtProductSaleQuantity.Margin = new Padding(3, 4, 3, 4);
            txtProductSaleQuantity.Name = "txtProductSaleQuantity";
            txtProductSaleQuantity.Size = new Size(174, 23);
            txtProductSaleQuantity.TabIndex = 23;
            // 
            // lblProductPrice
            // 
            lblProductPrice.Location = new Point(807, 65);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(100, 23);
            lblProductPrice.TabIndex = 24;
            lblProductPrice.Text = "Price:";
            // 
            // txtProductVat
            // 
            txtProductVat.Location = new Point(951, 91);
            txtProductVat.Name = "txtProductVat";
            txtProductVat.ReadOnly = true;
            txtProductVat.Size = new Size(111, 23);
            txtProductVat.TabIndex = 25;
            // 
            // lblProductVat
            // 
            lblProductVat.Location = new Point(949, 65);
            lblProductVat.Name = "lblProductVat";
            lblProductVat.Size = new Size(100, 23);
            lblProductVat.TabIndex = 26;
            lblProductVat.Text = "Vat:";
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(807, 91);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.ReadOnly = true;
            txtProductPrice.Size = new Size(136, 23);
            txtProductPrice.TabIndex = 27;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(627, 91);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(174, 23);
            txtProductName.TabIndex = 28;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(627, 187);
            txtProductId.Name = "txtProductId";
            txtProductId.ReadOnly = true;
            txtProductId.Size = new Size(54, 23);
            txtProductId.TabIndex = 34;
            txtProductId.Visible = false;
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.Location = new Point(490, 65);
            btnSearchProduct.Margin = new Padding(4, 3, 4, 3);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(120, 26);
            btnSearchProduct.TabIndex = 29;
            btnSearchProduct.Text = "Search";
            btnSearchProduct.UseVisualStyleBackColor = true;
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Location = new Point(14, 65);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(469, 23);
            txtSearchProduct.TabIndex = 30;
            // 
            // txtSearchSale
            // 
            txtSearchSale.Location = new Point(14, 232);
            txtSearchSale.Name = "txtSearchSale";
            txtSearchSale.Size = new Size(379, 23);
            txtSearchSale.TabIndex = 32;
            // 
            // btnSearchSale
            // 
            btnSearchSale.Location = new Point(400, 227);
            btnSearchSale.Margin = new Padding(4, 3, 4, 3);
            btnSearchSale.Name = "btnSearchSale";
            btnSearchSale.Size = new Size(91, 31);
            btnSearchSale.TabIndex = 31;
            btnSearchSale.Text = "Search";
            btnSearchSale.UseVisualStyleBackColor = true;
            // 
            // btnPrintReciept
            // 
            btnPrintReciept.Location = new Point(505, 227);
            btnPrintReciept.Margin = new Padding(4, 3, 4, 3);
            btnPrintReciept.Name = "btnPrintReciept";
            btnPrintReciept.Size = new Size(105, 31);
            btnPrintReciept.TabIndex = 33;
            btnPrintReciept.Text = "Print";
            btnPrintReciept.UseVisualStyleBackColor = true;
            // 
            // lblVatTotal
            // 
            lblVatTotal.Location = new Point(949, 123);
            lblVatTotal.Name = "lblVatTotal";
            lblVatTotal.Size = new Size(85, 23);
            lblVatTotal.TabIndex = 35;
            lblVatTotal.Text = "Vat Total:";
            // 
            // txtVatTotal
            // 
            txtVatTotal.Location = new Point(951, 149);
            txtVatTotal.Name = "txtVatTotal";
            txtVatTotal.ReadOnly = true;
            txtVatTotal.Size = new Size(111, 23);
            txtVatTotal.TabIndex = 36;
            // 
            // dataGridView1
            // 
            dataGridView1.Location = new Point(627, 227);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(424, 221);
            dataGridView1.TabIndex = 37;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(666, 454);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(368, 38);
            btnSave.TabIndex = 38;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // ProductSaleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSave);
            Controls.Add(dataGridView1);
            Controls.Add(lblVatTotal);
            Controls.Add(txtVatTotal);
            Controls.Add(btnPrintReciept);
            Controls.Add(txtSearchSale);
            Controls.Add(btnSearchSale);
            Controls.Add(txtSearchProduct);
            Controls.Add(btnSearchProduct);
            Controls.Add(txtProductName);
            Controls.Add(txtProductId);
            Controls.Add(txtProductPrice);
            Controls.Add(lblProductVat);
            Controls.Add(txtProductVat);
            Controls.Add(lblProductPrice);
            Controls.Add(txtProductSaleQuantity);
            Controls.Add(dataGridViewProductSales);
            Controls.Add(panel1);
            Controls.Add(dataGridViewProducts);
            Controls.Add(lblProductName);
            Controls.Add(lblProductSaleQuantity);
            Controls.Add(lblSaleTotal);
            Controls.Add(txtSaleTotal);
            Controls.Add(btnAddOrder);
            Controls.Add(btnCancel);
            Name = "ProductSaleForm";
            Size = new Size(1065, 500);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panel1;
        private Label label1;
        private Label lblProductName;
        private Label lblProductSaleQuantity;
        private Label lblSaleTotal;
        private Label lblProductPrice;
        private Label lblProductVat;
        private TextBox txtSaleTotal;
        private TextBox txtProductSaleQuantity;
        private TextBox txtProductVat;
        private TextBox txtProductPrice;
        private TextBox txtProductName;
        private TextBox txtProductId;
        private TextBox txtSearchProduct;
        private TextBox txtSearchSale;
        private Button btnCancel;
        private Button btnAddOrder;
        private Button btnSearchProduct;
        private Button btnSearchSale;
        private Button btnPrintReciept;
        private DataGridView dataGridViewProducts;
        private DataGridView dataGridViewProductSales;
        private Label lblVatTotal;
        private TextBox txtVatTotal;
        private DataGridView dataGridView1;
        private Button button1;
        private Button btnSave;
    }
}

