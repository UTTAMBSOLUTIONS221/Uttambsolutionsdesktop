namespace Uttambsolutionsdesktop.Forms
{
    partial class ProductBrandForm
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
            tabPageProductBrandList = new TabPage();
            dataGridView = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAddNew = new Button();
            tabPageProductBrandDetail = new TabPage();
            btnCancel = new Button();
            btnSave = new Button();
            labelProductBrandId = new Label();
            txtProductBrandId = new TextBox();
            labelProductBrandName = new Label();
            txtProductBrandName = new TextBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageProductBrandList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tabPageProductBrandDetail.SuspendLayout();
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
            label1.Text = "PRODUCT BRANDS";
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
            tabControl1.Controls.Add(tabPageProductBrandList);
            tabControl1.Controls.Add(tabPageProductBrandDetail);
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
            tabPageProductBrandList.Controls.Add(dataGridView);
            tabPageProductBrandList.Controls.Add(btnDelete);
            tabPageProductBrandList.Controls.Add(btnEdit);
            tabPageProductBrandList.Controls.Add(btnAddNew);
            tabPageProductBrandList.Location = new Point(4, 24);
            tabPageProductBrandList.Margin = new Padding(4, 3, 4, 3);
            tabPageProductBrandList.Name = "tabPageProductBrandList";
            tabPageProductBrandList.Padding = new Padding(4, 3, 4, 3);
            tabPageProductBrandList.Size = new Size(1033, 446);
            tabPageProductBrandList.TabIndex = 0;
            tabPageProductBrandList.Text = "Product Brand List";
            tabPageProductBrandList.UseVisualStyleBackColor = true;
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
            // tabPageProductDetail
            // 
            tabPageProductBrandDetail.Controls.Add(btnCancel);
            tabPageProductBrandDetail.Controls.Add(btnSave);
            tabPageProductBrandDetail.Controls.Add(labelProductBrandId);
            tabPageProductBrandDetail.Controls.Add(txtProductBrandId);
            tabPageProductBrandDetail.Controls.Add(labelProductBrandName);
            tabPageProductBrandDetail.Controls.Add(txtProductBrandName);
           
            tabPageProductBrandDetail.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageProductBrandDetail.Location = new Point(4, 24);
            tabPageProductBrandDetail.Margin = new Padding(4, 3, 4, 3);
            tabPageProductBrandDetail.Name = "tabPageProductBrandDetail";
            tabPageProductBrandDetail.Padding = new Padding(4, 3, 4, 3);
            tabPageProductBrandDetail.Size = new Size(1033, 446);
            tabPageProductBrandDetail.TabIndex = 1;
            tabPageProductBrandDetail.Text = "Product Brand Detail";
            tabPageProductBrandDetail.UseVisualStyleBackColor = true;
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
            // labelProductId
            // 
            labelProductBrandId.AutoSize = true;
            labelProductBrandId.Location = new Point(154, 26);
            labelProductBrandId.Margin = new Padding(4, 0, 4, 0);
            labelProductBrandId.Name = "labelProductBrandId";
            labelProductBrandId.Size = new Size(80, 24);
            labelProductBrandId.TabIndex = 16;
            labelProductBrandId.Text = "Product Brand:";
            labelProductBrandId.Visible = false;
            // 
            // txtProductId
            // 
            txtProductBrandId.Location = new Point(154, 53);
            txtProductBrandId.Margin = new Padding(4, 3, 4, 3);
            txtProductBrandId.Name = "txtProductBrandId";
            txtProductBrandId.Size = new Size(674, 29);
            txtProductBrandId.TabIndex = 17;
            txtProductBrandId.Visible = false;
            // 
            // labelProductName
            // 
            labelProductBrandName.AutoSize = true;
            labelProductBrandName.Location = new Point(153, 97);
            labelProductBrandName.Margin = new Padding(4, 0, 4, 0);
            labelProductBrandName.Name = "labelProductBrandName";
            labelProductBrandName.Size = new Size(136, 24);
            labelProductBrandName.TabIndex = 12;
            labelProductBrandName.Text = "Product Brand Name:";
            // 
            // txtProductName
            // 
            txtProductBrandName.Location = new Point(153, 124);
            txtProductBrandName.Margin = new Padding(4, 3, 4, 3);
            txtProductBrandName.Name = "txtProductBrandName";
            txtProductBrandName.Size = new Size(675, 29);
            txtProductBrandName.TabIndex = 18;
            // 
            // ProductPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductBrandPageForm";
            Size = new Size(1041, 539);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageProductBrandList.ResumeLayout(false);
            tabPageProductBrandList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tabPageProductBrandDetail.ResumeLayout(false);
            tabPageProductBrandDetail.PerformLayout();
            ResumeLayout(false);
        }

        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPageProductBrandList;
        private DataGridView dataGridView;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAddNew;
        private TabPage tabPageProductBrandDetail;
        private Button btnCancel;
        private Button btnSave;
        private Label labelProductBrandId;
        private TextBox txtProductBrandId;
        private Label labelProductBrandName;
        private TextBox txtProductBrandName;       
    }
}
