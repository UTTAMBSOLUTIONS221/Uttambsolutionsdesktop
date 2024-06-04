﻿namespace Uttambsolutionsdesktop.Forms
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
            label2 = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAddNew = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            tabPageProductDetail = new TabPage();
            btnCancel = new Button();
            btnSave = new Button();
            label3 = new Label();
            txtProductId = new TextBox();
            txtProductName = new TextBox();
            txtUomId = new TextBox();
            txtCategoryId = new TextBox();
            txtTaxCategoryId = new TextBox();
            txtBarcode = new TextBox();
            txtUnits = new TextBox();
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
            label1.Size = new Size(246, 25);
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
            tabPageProductList.Controls.Add(label2);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(938, 215);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 5;
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
            tabPageProductDetail.Controls.Add(label3);
            tabPageProductDetail.Controls.Add(txtProductName);
            tabPageProductDetail.Controls.Add(txtCategoryId);
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
            btnCancel.Location = new Point(263, 140);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(183, 44);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(72, 140);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(183, 44);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(63, 20);
            txtProductId.Margin = new Padding(4, 3, 4, 3);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(100, 29);
            txtProductId.TabIndex = 17;
            txtProductId.Visible = false;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(63, 108);
            txtProductName.Margin = new Padding(4, 3, 4, 3);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(380, 29);
            txtProductName.TabIndex = 18;
            // 
            // txtUomId
            // 
            txtUomId.Location = new Point(63, 152);
            txtUomId.Margin = new Padding(4, 3, 4, 3);
            txtUomId.Name = "txtUomId";
            txtUomId.Size = new Size(100, 29);
            txtUomId.TabIndex = 19;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(63, 196);
            txtCategoryId.Margin = new Padding(4, 3, 4, 3);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(100, 29);
            txtCategoryId.TabIndex = 20;
            // 
            // txtTaxCategoryId
            // 
            txtTaxCategoryId.Location = new Point(63, 240);
            txtTaxCategoryId.Margin = new Padding(4, 3, 4, 3);
            txtTaxCategoryId.Name = "txtTaxCategoryId";
            txtTaxCategoryId.Size = new Size(100, 29);
            txtTaxCategoryId.TabIndex = 21;
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(63, 284);
            txtBarcode.Margin = new Padding(4, 3, 4, 3);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(380, 29);
            txtBarcode.TabIndex = 22;
            // 
            // txtUnits
            // 
            txtUnits.Location = new Point(63, 328);
            txtUnits.Margin = new Padding(4, 3, 4, 3);
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new Size(100, 29);
            txtUnits.TabIndex = 23;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(63, 372);
            txtPrice.Margin = new Padding(4, 3, 4, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 29);
            txtPrice.TabIndex = 24;
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
        private Label label2;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAddNew;
        private Button btnSearch;
        private TextBox txtSearch;
        private TabPage tabPageProductDetail;
        private Button btnCancel;
        private Button btnSave;
        private Label label3;
        private TextBox txtCategoryId;
        private TextBox txtProductId;
        private TextBox txtProductName;
        private TextBox txtUomId;
        private TextBox txtTaxCategoryId;
        private TextBox txtBarcode;
        private TextBox txtUnits;
        private TextBox txtPrice;
    }
}
