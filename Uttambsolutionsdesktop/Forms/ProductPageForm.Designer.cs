namespace Uttambsolutionsdesktop.Forms
{
    partial class ProductPageForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPageProductList = new TabPage();
            dataGridView = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAddNew = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            tabPageProductDetail = new TabPage();
            btnCancel = new Button();
            btnSave = new Button();
            labelProductId = new Label();
            txtProductId = new TextBox();
            labelProductName = new Label();
            txtProductName = new TextBox();
            labelUomId = new Label();
            comboBoxUomId = new ComboBox();
            labelMainCategoryId = new Label();
            comboBoxMainCategoryId = new ComboBox();
            labelFirstCategoryId = new Label();
            comboBoxFirstCategoryId = new ComboBox();
            labelBrandId = new Label();
            comboBoxBrandId = new ComboBox();
            labelTaxCategoryId = new Label();
            comboBoxTaxCategoryId = new ComboBox();
            labelBarcode = new Label();
            txtBarcode = new TextBox();
            labelProductUnits = new Label();
            txtProductUnits = new TextBox();
            labelWholeSalePrice = new Label();
            txtWholeSalePrice = new TextBox();
            labelRetailSalePrice = new Label();
            txtRetailSalePrice = new TextBox();
            labelProductSize = new Label();
            txtProductSize = new TextBox();
            labelProductColor = new Label();
            txtProductColor = new TextBox();
            labelProductWeight = new Label();
            txtProductWeight = new TextBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tabPageProductDetail.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 21);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1041, 65);
            panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductList);
            tabControl1.Controls.Add(tabPageProductDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 65);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1041, 474);
            tabControl1.TabIndex = 2;
            // 
            // tabPageProductList
            // 
            tabPageProductList.Controls.Add(dataGridView);
            tabPageProductList.Controls.Add(btnDelete);
            tabPageProductList.Controls.Add(btnEdit);
            tabPageProductList.Controls.Add(btnAddNew);
            tabPageProductList.Controls.Add(btnSearch);
            tabPageProductList.Controls.Add(txtSearch);
            tabPageProductList.Location = new Point(4, 24);
            tabPageProductList.Margin = new Padding(4, 3, 4, 3);
            tabPageProductList.Name = "tabPageProductList";
            tabPageProductList.Padding = new Padding(4, 3, 4, 3);
            tabPageProductList.Size = new Size(1033, 446);
            tabPageProductList.TabIndex = 0;
            tabPageProductList.Text = "Product List";
            tabPageProductList.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(28, 82);
            dataGridView.Margin = new Padding(4, 3, 4, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(845, 335);
            dataGridView.TabIndex = 6;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(883, 160);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 25);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(883, 129);
            btnEdit.Margin = new Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 25);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(881, 89);
            btnAddNew.Margin = new Padding(4, 3, 4, 3);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(84, 25);
            btnAddNew.TabIndex = 2;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(767, 36);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(106, 25);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(28, 36);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(719, 23);
            txtSearch.TabIndex = 0;
            // 
            // tabPageProductDetail
            // 
            tabPageProductDetail.Controls.Add(btnCancel);
            tabPageProductDetail.Controls.Add(btnSave);
            tabPageProductDetail.Controls.Add(labelProductId);
            tabPageProductDetail.Controls.Add(txtProductId);
            tabPageProductDetail.Controls.Add(labelProductName);
            tabPageProductDetail.Controls.Add(txtProductName);
            tabPageProductDetail.Controls.Add(labelUomId);
            tabPageProductDetail.Controls.Add(comboBoxUomId);
            tabPageProductDetail.Controls.Add(labelMainCategoryId);
            tabPageProductDetail.Controls.Add(comboBoxMainCategoryId);
            tabPageProductDetail.Controls.Add(labelFirstCategoryId);
            tabPageProductDetail.Controls.Add(comboBoxFirstCategoryId);
            tabPageProductDetail.Controls.Add(labelBrandId);
            tabPageProductDetail.Controls.Add(comboBoxBrandId);
            tabPageProductDetail.Controls.Add(labelTaxCategoryId);
            tabPageProductDetail.Controls.Add(comboBoxTaxCategoryId);
            tabPageProductDetail.Controls.Add(labelBarcode);
            tabPageProductDetail.Controls.Add(txtBarcode);
            tabPageProductDetail.Controls.Add(labelProductUnits);
            tabPageProductDetail.Controls.Add(txtProductUnits);
            tabPageProductDetail.Controls.Add(labelWholeSalePrice);
            tabPageProductDetail.Controls.Add(txtWholeSalePrice);
            tabPageProductDetail.Controls.Add(labelRetailSalePrice);
            tabPageProductDetail.Controls.Add(txtRetailSalePrice);
            tabPageProductDetail.Controls.Add(labelProductSize);
            tabPageProductDetail.Controls.Add(txtProductSize);
            tabPageProductDetail.Controls.Add(labelProductColor);
            tabPageProductDetail.Controls.Add(txtProductColor);
            tabPageProductDetail.Controls.Add(labelProductWeight);
            tabPageProductDetail.Controls.Add(txtProductWeight);
            tabPageProductDetail.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageProductDetail.Location = new Point(4, 24);
            tabPageProductDetail.Margin = new Padding(4, 3, 4, 3);
            tabPageProductDetail.Name = "tabPageProductDetail";
            tabPageProductDetail.Padding = new Padding(4, 3, 4, 3);
            tabPageProductDetail.Size = new Size(1033, 446);
            tabPageProductDetail.TabIndex = 1;
            tabPageProductDetail.Text = "Product Detail";
            tabPageProductDetail.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(686, 310);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(183, 44);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(179, 310);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(183, 44);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // labelProductId
            // 
            labelProductId.AutoSize = true;
            labelProductId.Location = new Point(154, 26);
            labelProductId.Margin = new Padding(4, 0, 4, 0);
            labelProductId.Name = "labelProductId";
            labelProductId.Size = new Size(80, 24);
            labelProductId.TabIndex = 16;
            labelProductId.Text = "Product:";
            labelProductId.Visible = false;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(242, 27);
            txtProductId.Margin = new Padding(4, 3, 4, 3);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(186, 29);
            txtProductId.TabIndex = 17;
            txtProductId.Visible = false;
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Location = new Point(46, 70);
            labelProductName.Margin = new Padding(4, 0, 4, 0);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(136, 24);
            labelProductName.TabIndex = 12;
            labelProductName.Text = "Product Name:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(46, 103);
            txtProductName.Margin = new Padding(4, 3, 4, 3);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(242, 29);
            txtProductName.TabIndex = 18;
            // 
            // labelUomId
            // 
            labelUomId.AutoSize = true;
            labelUomId.Location = new Point(836, 70);
            labelUomId.Margin = new Padding(4, 0, 4, 0);
            labelUomId.Name = "labelUomId";
            labelUomId.Size = new Size(55, 24);
            labelUomId.TabIndex = 19;
            labelUomId.Text = "Uom:";
            // 
            // comboBoxUomId
            // 
            comboBoxUomId.FormattingEnabled = true;
            comboBoxUomId.Location = new Point(826, 103);
            comboBoxUomId.Name = "comboBoxUomId";
            comboBoxUomId.Size = new Size(200, 32);
            comboBoxUomId.TabIndex = 20;
            // 
            // labelMainCategoryId
            // 
            labelMainCategoryId.AutoSize = true;
            labelMainCategoryId.Location = new Point(296, 149);
            labelMainCategoryId.Margin = new Padding(4, 0, 4, 0);
            labelMainCategoryId.Name = "labelMainCategoryId";
            labelMainCategoryId.Size = new Size(136, 24);
            labelMainCategoryId.TabIndex = 19;
            labelMainCategoryId.Text = "Main Category:";
            // 
            // comboBoxMainCategoryId
            // 
            comboBoxMainCategoryId.Location = new Point(296, 176);
            comboBoxMainCategoryId.Margin = new Padding(4, 3, 4, 3);
            comboBoxMainCategoryId.Name = "comboBoxMainCategoryId";
            comboBoxMainCategoryId.Size = new Size(244, 32);
            comboBoxMainCategoryId.TabIndex = 20;
            // 
            // labelFirstCategoryId
            // 
            labelFirstCategoryId.AutoSize = true;
            labelFirstCategoryId.Location = new Point(612, 149);
            labelFirstCategoryId.Margin = new Padding(4, 0, 4, 0);
            labelFirstCategoryId.Name = "labelFirstCategoryId";
            labelFirstCategoryId.Size = new Size(130, 24);
            labelFirstCategoryId.TabIndex = 21;
            labelFirstCategoryId.Text = "First Category:";
            // 
            // comboBoxFirstCategoryId
            // 
            comboBoxFirstCategoryId.Location = new Point(556, 176);
            comboBoxFirstCategoryId.Margin = new Padding(4, 3, 4, 3);
            comboBoxFirstCategoryId.Name = "comboBoxFirstCategoryId";
            comboBoxFirstCategoryId.Size = new Size(252, 32);
            comboBoxFirstCategoryId.TabIndex = 22;
            // 
            // labelBrandId
            // 
            labelBrandId.AutoSize = true;
            labelBrandId.Location = new Point(556, 73);
            labelBrandId.Margin = new Padding(4, 0, 4, 0);
            labelBrandId.Name = "labelBrandId";
            labelBrandId.Size = new Size(65, 24);
            labelBrandId.TabIndex = 23;
            labelBrandId.Text = "Brand:";
            // 
            // comboBoxBrandId
            // 
            comboBoxBrandId.Location = new Point(556, 103);
            comboBoxBrandId.Margin = new Padding(4, 3, 4, 3);
            comboBoxBrandId.Name = "comboBoxBrandId";
            comboBoxBrandId.Size = new Size(252, 32);
            comboBoxBrandId.TabIndex = 24;
            // 
            // labelTaxCategoryId
            // 
            labelTaxCategoryId.AutoSize = true;
            labelTaxCategoryId.Location = new Point(46, 149);
            labelTaxCategoryId.Margin = new Padding(4, 0, 4, 0);
            labelTaxCategoryId.Name = "labelTaxCategoryId";
            labelTaxCategoryId.Size = new Size(127, 24);
            labelTaxCategoryId.TabIndex = 25;
            labelTaxCategoryId.Text = "Tax Category:";
            // 
            // comboBoxTaxCategoryId
            // 
            comboBoxTaxCategoryId.Location = new Point(45, 176);
            comboBoxTaxCategoryId.Margin = new Padding(4, 3, 4, 3);
            comboBoxTaxCategoryId.Name = "comboBoxTaxCategoryId";
            comboBoxTaxCategoryId.Size = new Size(243, 32);
            comboBoxTaxCategoryId.TabIndex = 26;
            // 
            // labelBarcode
            // 
            labelBarcode.AutoSize = true;
            labelBarcode.Location = new Point(296, 73);
            labelBarcode.Margin = new Padding(4, 0, 4, 0);
            labelBarcode.Name = "labelBarcode";
            labelBarcode.Size = new Size(86, 24);
            labelBarcode.TabIndex = 27;
            labelBarcode.Text = "Barcode:";
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(296, 103);
            txtBarcode.Margin = new Padding(4, 3, 4, 3);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(244, 29);
            txtBarcode.TabIndex = 28;
            // 
            // labelProductUnits
            // 
            labelProductUnits.AutoSize = true;
            labelProductUnits.Location = new Point(46, 219);
            labelProductUnits.Margin = new Padding(4, 0, 4, 0);
            labelProductUnits.Name = "labelProductUnits";
            labelProductUnits.Size = new Size(126, 24);
            labelProductUnits.TabIndex = 29;
            labelProductUnits.Text = "Product Units:";
            // 
            // txtProductUnits
            // 
            txtProductUnits.Location = new Point(46, 246);
            txtProductUnits.Margin = new Padding(4, 3, 4, 3);
            txtProductUnits.Name = "txtProductUnits";
            txtProductUnits.Size = new Size(160, 29);
            txtProductUnits.TabIndex = 30;
            // 
            // labelWholeSalePrice
            // 
            labelWholeSalePrice.AutoSize = true;
            labelWholeSalePrice.Location = new Point(604, 219);
            labelWholeSalePrice.Margin = new Padding(4, 0, 4, 0);
            labelWholeSalePrice.Name = "labelWholeSalePrice";
            labelWholeSalePrice.Size = new Size(160, 24);
            labelWholeSalePrice.TabIndex = 31;
            labelWholeSalePrice.Text = "Whole Sale Price:";
            // 
            // txtWholeSalePrice
            // 
            txtWholeSalePrice.Location = new Point(604, 246);
            txtWholeSalePrice.Margin = new Padding(4, 3, 4, 3);
            txtWholeSalePrice.Name = "txtWholeSalePrice";
            txtWholeSalePrice.Size = new Size(224, 29);
            txtWholeSalePrice.TabIndex = 32;
            // 
            // labelRetailSalePrice
            // 
            labelRetailSalePrice.AutoSize = true;
            labelRetailSalePrice.Location = new Point(836, 219);
            labelRetailSalePrice.Margin = new Padding(4, 0, 4, 0);
            labelRetailSalePrice.Name = "labelRetailSalePrice";
            labelRetailSalePrice.Size = new Size(151, 24);
            labelRetailSalePrice.TabIndex = 33;
            labelRetailSalePrice.Text = "Retail Sale Price:";
            // 
            // txtRetailSalePrice
            // 
            txtRetailSalePrice.Location = new Point(836, 246);
            txtRetailSalePrice.Margin = new Padding(4, 3, 4, 3);
            txtRetailSalePrice.Name = "txtRetailSalePrice";
            txtRetailSalePrice.Size = new Size(190, 29);
            txtRetailSalePrice.TabIndex = 34;
            // 
            // labelProductSize
            // 
            labelProductSize.AutoSize = true;
            labelProductSize.Location = new Point(826, 152);
            labelProductSize.Margin = new Padding(4, 0, 4, 0);
            labelProductSize.Name = "labelProductSize";
            labelProductSize.Size = new Size(121, 24);
            labelProductSize.TabIndex = 35;
            labelProductSize.Text = "Product Size:";
            // 
            // txtProductSize
            // 
            txtProductSize.Location = new Point(826, 179);
            txtProductSize.Margin = new Padding(4, 3, 4, 3);
            txtProductSize.Name = "txtProductSize";
            txtProductSize.Size = new Size(200, 29);
            txtProductSize.TabIndex = 36;
            // 
            // labelProductColor
            // 
            labelProductColor.AutoSize = true;
            labelProductColor.Location = new Point(214, 219);
            labelProductColor.Margin = new Padding(4, 0, 4, 0);
            labelProductColor.Name = "labelProductColor";
            labelProductColor.Size = new Size(130, 24);
            labelProductColor.TabIndex = 37;
            labelProductColor.Text = "Product Color:";
            // 
            // txtProductColor
            // 
            txtProductColor.Location = new Point(214, 246);
            txtProductColor.Margin = new Padding(4, 3, 4, 3);
            txtProductColor.Name = "txtProductColor";
            txtProductColor.Size = new Size(168, 29);
            txtProductColor.TabIndex = 38;
            // 
            // labelProductWeight
            // 
            labelProductWeight.AutoSize = true;
            labelProductWeight.Location = new Point(390, 219);
            labelProductWeight.Margin = new Padding(4, 0, 4, 0);
            labelProductWeight.Name = "labelProductWeight";
            labelProductWeight.Size = new Size(144, 24);
            labelProductWeight.TabIndex = 39;
            labelProductWeight.Text = "Product Weight:";
            // 
            // txtProductWeight
            // 
            txtProductWeight.Location = new Point(390, 246);
            txtProductWeight.Margin = new Padding(4, 3, 4, 3);
            txtProductWeight.Name = "txtProductWeight";
            txtProductWeight.Size = new Size(206, 29);
            txtProductWeight.TabIndex = 40;
            // 
            // ProductPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductPageForm";
            Size = new Size(1041, 539);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageProductList.ResumeLayout(false);
            tabPageProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tabPageProductDetail.ResumeLayout(false);
            tabPageProductDetail.PerformLayout();
            ResumeLayout(false);
        }

        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPageProductList;
        private DataGridView dataGridView;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAddNew;
        private Button btnSearch;
        private TextBox txtSearch;
        private TabPage tabPageProductDetail;
        private Button btnCancel;
        private Button btnSave;
        private Label labelProductId;
        private TextBox txtProductId;
        private Label labelProductName;
        private TextBox txtProductName;
        private Label labelUomId;
        private ComboBox comboBoxUomId;
        private Label labelMainCategoryId;
        private ComboBox comboBoxMainCategoryId;
        private Label labelFirstCategoryId;
        private ComboBox comboBoxFirstCategoryId;
        private Label labelBrandId;
        private ComboBox comboBoxBrandId;
        private Label labelTaxCategoryId;
        private ComboBox comboBoxTaxCategoryId;
        private Label labelBarcode;
        private TextBox txtBarcode;
        private Label labelProductUnits;
        private TextBox txtProductUnits;
        private Label labelWholeSalePrice;
        private TextBox txtWholeSalePrice;
        private Label labelRetailSalePrice;
        private TextBox txtRetailSalePrice;
        private Label labelProductSize;
        private TextBox txtProductSize;
        private Label labelProductColor;
        private TextBox txtProductColor;
        private Label labelProductWeight;
        private TextBox txtProductWeight;
    }
}
