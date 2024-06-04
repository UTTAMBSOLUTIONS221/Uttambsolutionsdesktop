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
            labelCategoryId = new Label();
            comboBoxCategoryId = new ComboBox();
            labelTaxCategoryId = new Label();
            comboBoxTaxCategoryId = new ComboBox();
            labelBarcode = new Label();
            txtBarcode = new TextBox();
            labelUnits = new Label();
            txtUnits = new TextBox();
            labelPrice = new Label();
            txtPrice = new TextBox();
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
            tabPageProductDetail.Controls.Add(labelCategoryId);
            tabPageProductDetail.Controls.Add(comboBoxCategoryId);
            tabPageProductDetail.Controls.Add(labelTaxCategoryId);
            tabPageProductDetail.Controls.Add(comboBoxTaxCategoryId);
            tabPageProductDetail.Controls.Add(labelBarcode);
            tabPageProductDetail.Controls.Add(txtBarcode);
            tabPageProductDetail.Controls.Add(labelUnits);
            tabPageProductDetail.Controls.Add(txtUnits);
            tabPageProductDetail.Controls.Add(labelPrice);
            tabPageProductDetail.Controls.Add(txtPrice);
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
            btnCancel.Location = new Point(529, 338);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(183, 44);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(258, 338);
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
            labelProductId.Location = new Point(205, 26);
            labelProductId.Margin = new Padding(4, 0, 4, 0);
            labelProductId.Name = "labelProductId";
            labelProductId.Size = new Size(80, 24);
            labelProductId.TabIndex = 16;
            labelProductId.Text = "Product:";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(205, 53);
            txtProductId.Margin = new Padding(4, 3, 4, 3);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(613, 29);
            txtProductId.TabIndex = 17;
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Location = new Point(204, 97);
            labelProductName.Margin = new Padding(4, 0, 4, 0);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(136, 24);
            labelProductName.TabIndex = 12;
            labelProductName.Text = "Product Name:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(204, 124);
            txtProductName.Margin = new Padding(4, 3, 4, 3);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(614, 29);
            txtProductName.TabIndex = 18;
            // 
            // labelUomId
            // 
            labelUomId.AutoSize = true;
            labelUomId.Location = new Point(205, 167);
            labelUomId.Margin = new Padding(4, 0, 4, 0);
            labelUomId.Name = "labelUomId";
            labelUomId.Size = new Size(55, 24);
            labelUomId.TabIndex = 19;
            labelUomId.Text = "Uom:";
            // 
            // comboBoxUomId
            // 
            comboBoxUomId.FormattingEnabled = true;
            comboBoxUomId.Location = new Point(205, 205);
            comboBoxUomId.Name = "comboBoxUomId";
            comboBoxUomId.Size = new Size(183, 32);
            comboBoxUomId.TabIndex = 20;
            // 
            // labelCategoryId
            // 
            labelCategoryId.AutoSize = true;
            labelCategoryId.Location = new Point(434, 167);
            labelCategoryId.Margin = new Padding(4, 0, 4, 0);
            labelCategoryId.Name = "labelCategoryId";
            labelCategoryId.Size = new Size(90, 24);
            labelCategoryId.TabIndex = 13;
            labelCategoryId.Text = "Category:";
            // 
            // comboBoxCategoryId
            // 
            comboBoxCategoryId.FormattingEnabled = true;
            comboBoxCategoryId.Location = new Point(434, 205);
            comboBoxCategoryId.Name = "comboBoxCategoryId";
            comboBoxCategoryId.Size = new Size(183, 32);
            comboBoxCategoryId.TabIndex = 21;
            // 
            // labelTaxCategoryId
            // 
            labelTaxCategoryId.AutoSize = true;
            labelTaxCategoryId.Location = new Point(635, 167);
            labelTaxCategoryId.Margin = new Padding(4, 0, 4, 0);
            labelTaxCategoryId.Name = "labelTaxCategoryId";
            labelTaxCategoryId.Size = new Size(127, 24);
            labelTaxCategoryId.TabIndex = 22;
            labelTaxCategoryId.Text = "Tax Category:";
            // 
            // comboBoxTaxCategoryId
            // 
            comboBoxTaxCategoryId.FormattingEnabled = true;
            comboBoxTaxCategoryId.Location = new Point(635, 205);
            comboBoxTaxCategoryId.Name = "comboBoxTaxCategoryId";
            comboBoxTaxCategoryId.Size = new Size(183, 32);
            comboBoxTaxCategoryId.TabIndex = 23;
            // 
            // labelBarcode
            // 
            labelBarcode.AutoSize = true;
            labelBarcode.Location = new Point(205, 249);
            labelBarcode.Margin = new Padding(4, 0, 4, 0);
            labelBarcode.Name = "labelBarcode";
            labelBarcode.Size = new Size(86, 24);
            labelBarcode.TabIndex = 24;
            labelBarcode.Text = "Barcode:";
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(205, 285);
            txtBarcode.Margin = new Padding(4, 3, 4, 3);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(183, 29);
            txtBarcode.TabIndex = 25;
            // 
            // labelUnits
            // 
            labelUnits.AutoSize = true;
            labelUnits.Location = new Point(434, 249);
            labelUnits.Margin = new Padding(4, 0, 4, 0);
            labelUnits.Name = "labelUnits";
            labelUnits.Size = new Size(56, 24);
            labelUnits.TabIndex = 26;
            labelUnits.Text = "Units:";
            // 
            // txtUnits
            // 
            txtUnits.Location = new Point(434, 285);
            txtUnits.Margin = new Padding(4, 3, 4, 3);
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new Size(183, 29);
            txtUnits.TabIndex = 27;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(635, 249);
            labelPrice.Margin = new Padding(4, 0, 4, 0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(58, 24);
            labelPrice.TabIndex = 28;
            labelPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(635, 285);
            txtPrice.Margin = new Padding(4, 3, 4, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(183, 29);
            txtPrice.TabIndex = 29;
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
        private Label labelCategoryId;
        private ComboBox comboBoxCategoryId;
        private Label labelTaxCategoryId;
        private ComboBox comboBoxTaxCategoryId;
        private Label labelBarcode;
        private TextBox txtBarcode;
        private Label labelUnits;
        private TextBox txtUnits;
        private Label labelPrice;
        private TextBox txtPrice;
    }
}
