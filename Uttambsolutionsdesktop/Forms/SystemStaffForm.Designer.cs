﻿namespace Uttambsolutionsdesktop.Forms
{
    partial class SystemStaffForm
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
            tabPageStaffList = new TabPage();
            dataGridView = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAddNew = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            tabPageStaffDetail = new TabPage();
            btnCancel = new Button();
            btnSave = new Button();
            labelStaffId = new Label();
            txtStaffId = new TextBox();
            labelStaffName = new Label();
            txtStaffName = new TextBox();
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
            tabPageStaffList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tabPageStaffDetail.SuspendLayout();
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
            label1.Text = "STAFFS";
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
            tabControl1.Controls.Add(tabPageStaffList);
            tabControl1.Controls.Add(tabPageStaffDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 65);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1041, 474);
            tabControl1.TabIndex = 2;
            // 
            // tabPageStaffList
            // 
            tabPageStaffList.Controls.Add(dataGridView);
            tabPageStaffList.Controls.Add(btnDelete);
            tabPageStaffList.Controls.Add(btnEdit);
            tabPageStaffList.Controls.Add(btnAddNew);
            tabPageStaffList.Controls.Add(btnSearch);
            tabPageStaffList.Controls.Add(txtSearch);
            tabPageStaffList.Location = new Point(4, 24);
            tabPageStaffList.Margin = new Padding(4, 3, 4, 3);
            tabPageStaffList.Name = "tabPageStaffList";
            tabPageStaffList.Padding = new Padding(4, 3, 4, 3);
            tabPageStaffList.Size = new Size(1033, 446);
            tabPageStaffList.TabIndex = 0;
            tabPageStaffList.Text = "Staffs List";
            tabPageStaffList.UseVisualStyleBackColor = true;
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
            // tabPageStaffDetail
            // 
            tabPageStaffDetail.Controls.Add(btnCancel);
            tabPageStaffDetail.Controls.Add(btnSave);
            tabPageStaffDetail.Controls.Add(labelStaffId);
            tabPageStaffDetail.Controls.Add(txtStaffId);
            tabPageStaffDetail.Controls.Add(labelStaffName);
            tabPageStaffDetail.Controls.Add(txtStaffName);
            tabPageStaffDetail.Controls.Add(labelUomId);
            tabPageStaffDetail.Controls.Add(comboBoxUomId);
            tabPageStaffDetail.Controls.Add(labelCategoryId);
            tabPageStaffDetail.Controls.Add(comboBoxCategoryId);
            tabPageStaffDetail.Controls.Add(labelTaxCategoryId);
            tabPageStaffDetail.Controls.Add(comboBoxTaxCategoryId);
            tabPageStaffDetail.Controls.Add(labelBarcode);
            tabPageStaffDetail.Controls.Add(txtBarcode);
            tabPageStaffDetail.Controls.Add(labelUnits);
            tabPageStaffDetail.Controls.Add(txtUnits);
            tabPageStaffDetail.Controls.Add(labelPrice);
            tabPageStaffDetail.Controls.Add(txtPrice);
            tabPageStaffDetail.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageStaffDetail.Location = new Point(4, 24);
            tabPageStaffDetail.Margin = new Padding(4, 3, 4, 3);
            tabPageStaffDetail.Name = "tabPageStaffDetail";
            tabPageStaffDetail.Padding = new Padding(4, 3, 4, 3);
            tabPageStaffDetail.Size = new Size(1033, 446);
            tabPageStaffDetail.TabIndex = 1;
            tabPageStaffDetail.Text = "Staff Detail";
            tabPageStaffDetail.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(501, 338);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(183, 44);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(230, 338);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(183, 44);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // labelStaffId
            // 
            labelStaffId.AutoSize = true;
            labelStaffId.Location = new Point(154, 26);
            labelStaffId.Margin = new Padding(4, 0, 4, 0);
            labelStaffId.Name = "labelStaffId";
            labelStaffId.Size = new Size(80, 24);
            labelStaffId.TabIndex = 16;
            labelStaffId.Text = "Staff:";
            labelStaffId.Visible = false;
            // 
            // txtStaffId
            // 
            txtStaffId.Location = new Point(154, 53);
            txtStaffId.Margin = new Padding(4, 3, 4, 3);
            txtStaffId.Name = "txtStaffId";
            txtStaffId.Size = new Size(674, 29);
            txtStaffId.TabIndex = 17;
            txtStaffId.Visible = false;
            // 
            // labelStaffName
            // 
            labelStaffName.AutoSize = true;
            labelStaffName.Location = new Point(153, 97);
            labelStaffName.Margin = new Padding(4, 0, 4, 0);
            labelStaffName.Name = "labelStaffName";
            labelStaffName.Size = new Size(136, 24);
            labelStaffName.TabIndex = 12;
            labelStaffName.Text = "Staff Name:";
            // 
            // txtStaffName
            // 
            txtStaffName.Location = new Point(153, 124);
            txtStaffName.Margin = new Padding(4, 3, 4, 3);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(675, 29);
            txtStaffName.TabIndex = 18;
            // 
            // labelUomId
            // 
            labelUomId.AutoSize = true;
            labelUomId.Location = new Point(154, 167);
            labelUomId.Margin = new Padding(4, 0, 4, 0);
            labelUomId.Name = "labelUomId";
            labelUomId.Size = new Size(55, 24);
            labelUomId.TabIndex = 19;
            labelUomId.Text = "Uom:";
            // 
            // comboBoxUomId
            // 
            comboBoxUomId.FormattingEnabled = true;
            comboBoxUomId.Location = new Point(154, 205);
            comboBoxUomId.Name = "comboBoxUomId";
            comboBoxUomId.Size = new Size(195, 32);
            comboBoxUomId.TabIndex = 20;
            // 
            // labelCategoryId
            // 
            labelCategoryId.AutoSize = true;
            labelCategoryId.Location = new Point(368, 178);
            labelCategoryId.Margin = new Padding(4, 0, 4, 0);
            labelCategoryId.Name = "labelCategoryId";
            labelCategoryId.Size = new Size(90, 24);
            labelCategoryId.TabIndex = 13;
            labelCategoryId.Text = "Category:";
            // 
            // comboBoxCategoryId
            // 
            comboBoxCategoryId.FormattingEnabled = true;
            comboBoxCategoryId.Location = new Point(368, 205);
            comboBoxCategoryId.Name = "comboBoxCategoryId";
            comboBoxCategoryId.Size = new Size(210, 32);
            comboBoxCategoryId.TabIndex = 21;
            // 
            // labelTaxCategoryId
            // 
            labelTaxCategoryId.AutoSize = true;
            labelTaxCategoryId.Location = new Point(597, 167);
            labelTaxCategoryId.Margin = new Padding(4, 0, 4, 0);
            labelTaxCategoryId.Name = "labelTaxCategoryId";
            labelTaxCategoryId.Size = new Size(127, 24);
            labelTaxCategoryId.TabIndex = 22;
            labelTaxCategoryId.Text = "Tax Category:";
            // 
            // comboBoxTaxCategoryId
            // 
            comboBoxTaxCategoryId.FormattingEnabled = true;
            comboBoxTaxCategoryId.Location = new Point(597, 205);
            comboBoxTaxCategoryId.Name = "comboBoxTaxCategoryId";
            comboBoxTaxCategoryId.Size = new Size(231, 32);
            comboBoxTaxCategoryId.TabIndex = 23;
            // 
            // labelBarcode
            // 
            labelBarcode.AutoSize = true;
            labelBarcode.Location = new Point(154, 249);
            labelBarcode.Margin = new Padding(4, 0, 4, 0);
            labelBarcode.Name = "labelBarcode";
            labelBarcode.Size = new Size(86, 24);
            labelBarcode.TabIndex = 24;
            labelBarcode.Text = "Barcode:";
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(154, 285);
            txtBarcode.Margin = new Padding(4, 3, 4, 3);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(195, 29);
            txtBarcode.TabIndex = 25;
            // 
            // labelUnits
            // 
            labelUnits.AutoSize = true;
            labelUnits.Location = new Point(368, 249);
            labelUnits.Margin = new Padding(4, 0, 4, 0);
            labelUnits.Name = "labelUnits";
            labelUnits.Size = new Size(56, 24);
            labelUnits.TabIndex = 26;
            labelUnits.Text = "Units:";
            // 
            // txtUnits
            // 
            txtUnits.Location = new Point(368, 285);
            txtUnits.Margin = new Padding(4, 3, 4, 3);
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new Size(210, 29);
            txtUnits.TabIndex = 27;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(597, 249);
            labelPrice.Margin = new Padding(4, 0, 4, 0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(58, 24);
            labelPrice.TabIndex = 28;
            labelPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(597, 285);
            txtPrice.Margin = new Padding(4, 3, 4, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(231, 29);
            txtPrice.TabIndex = 29;
            // 
            // StaffPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "StaffPageForm";
            Size = new Size(1041, 539);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageStaffList.ResumeLayout(false);
            tabPageStaffList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tabPageStaffDetail.ResumeLayout(false);
            tabPageStaffDetail.PerformLayout();
            ResumeLayout(false);
        }

        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPageStaffList;
        private DataGridView dataGridView;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAddNew;
        private Button btnSearch;
        private TextBox txtSearch;
        private TabPage tabPageStaffDetail;
        private Button btnCancel;
        private Button btnSave;
        private Label labelStaffId;
        private TextBox txtStaffId;
        private Label labelStaffName;
        private TextBox txtStaffName;
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