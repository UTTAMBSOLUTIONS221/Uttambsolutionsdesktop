using System;
using System.Drawing;
using System.Windows.Forms;

namespace Uttambsolutionsdesktop.Forms
{
    partial class ProductSaleForm
    {
        private Label label1;
        private Panel panel1;
        private TabPage tabPageCategoryDetail;
        private Button btnCancel;
        private Button btnSave;
        private Label label4;
        private Label label6;
        private TextBox txtCategoryId;
        private ComboBox comboMainCategoryId;
        private DataGridView dataGridView;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAddNew;
        private Label labelMainCategoryId;

        private Label labelCategoryName;
        private Label labelQuantity;
        private Label labelTotal;
        private TextBox txtTotal;
        public ProductSaleForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            tabPageCategoryDetail = new TabPage();
            label4 = new Label();
            label6 = new Label();
            txtCategoryId = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            comboMainCategoryId = new ComboBox();
            dataGridView = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAddNew = new Button();
            labelMainCategoryId = new Label();
            labelCategoryName = new Label();
            labelQuantity = new Label();
            labelTotal = new Label();
            txtTotal = new TextBox();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            tabPageCategoryDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
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
            // tabPageCategoryDetail
            // 
            tabPageCategoryDetail.Controls.Add(label4);
            tabPageCategoryDetail.Controls.Add(label6);
            tabPageCategoryDetail.Controls.Add(txtCategoryId);
            tabPageCategoryDetail.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageCategoryDetail.Location = new Point(4, 24);
            tabPageCategoryDetail.Margin = new Padding(4, 3, 4, 3);
            tabPageCategoryDetail.Name = "tabPageCategoryDetail";
            tabPageCategoryDetail.Padding = new Padding(4, 3, 4, 3);
            tabPageCategoryDetail.Size = new Size(1033, 446);
            tabPageCategoryDetail.TabIndex = 1;
            tabPageCategoryDetail.Text = "Category Detail";
            tabPageCategoryDetail.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(71, 101);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 13;
            label4.Text = "Category Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(71, 32);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 13;
            label6.Text = "Main Category:";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(281, 20);
            txtCategoryId.Margin = new Padding(4, 3, 4, 3);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(162, 29);
            txtCategoryId.TabIndex = 16;
            txtCategoryId.Visible = false;
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
            // btnSave
            // 
            btnSave.Location = new Point(681, 178);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 38);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // comboMainCategoryId
            // 
            comboMainCategoryId.Location = new Point(650, 20);
            comboMainCategoryId.Margin = new Padding(4, 3, 4, 3);
            comboMainCategoryId.Name = "comboMainCategoryId";
            comboMainCategoryId.Size = new Size(200, 23);
            comboMainCategoryId.TabIndex = 16;
            // 
            // dataGridView
            // 
            dataGridView.Location = new Point(14, 97);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(596, 119);
            dataGridView.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(790, 477);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 25);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(701, 477);
            btnEdit.Margin = new Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 25);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(609, 477);
            btnAddNew.Margin = new Padding(4, 3, 4, 3);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(84, 25);
            btnAddNew.TabIndex = 11;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            // 
            // labelMainCategoryId
            // 
            labelMainCategoryId.Location = new Point(530, 20);
            labelMainCategoryId.Name = "labelMainCategoryId";
            labelMainCategoryId.Size = new Size(100, 23);
            labelMainCategoryId.TabIndex = 3;
            labelMainCategoryId.Text = "Main Category:";
            // 
            // labelCategoryName
            // 
            labelCategoryName.Location = new Point(627, 65);
            labelCategoryName.Name = "labelCategoryName";
            labelCategoryName.Size = new Size(100, 23);
            labelCategoryName.TabIndex = 17;
            labelCategoryName.Text = "Product Name:";
            // 
            // labelQuantity
            // 
            labelQuantity.Location = new Point(627, 123);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(100, 23);
            labelQuantity.TabIndex = 18;
            labelQuantity.Text = "Quantity:";
            // 
            // labelTotal
            // 
            labelTotal.Location = new Point(821, 123);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(122, 23);
            labelTotal.TabIndex = 20;
            labelTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(820, 149);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(237, 23);
            txtTotal.TabIndex = 21;
            // 
            // dataGridView1
            // 
            dataGridView1.Location = new Point(14, 264);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(930, 221);
            dataGridView1.TabIndex = 22;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(627, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 23;
            // 
            // label2
            // 
            label2.Location = new Point(820, 65);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 24;
            label2.Text = "Price:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(951, 91);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(106, 23);
            textBox2.TabIndex = 25;
            // 
            // label3
            // 
            label3.Location = new Point(949, 65);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 26;
            label3.Text = "Vat:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(820, 91);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(123, 23);
            textBox3.TabIndex = 27;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(627, 91);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(174, 23);
            textBox4.TabIndex = 28;
            // 
            // button1
            // 
            button1.Location = new Point(490, 65);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(120, 26);
            button1.TabIndex = 29;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(14, 65);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(469, 23);
            textBox5.TabIndex = 30;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(14, 232);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(802, 23);
            textBox6.TabIndex = 32;
            // 
            // button2
            // 
            button2.Location = new Point(823, 232);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(120, 26);
            button2.TabIndex = 31;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(951, 264);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(105, 31);
            button3.TabIndex = 33;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            // 
            // ProductSaleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(textBox6);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(dataGridView);
            Controls.Add(labelMainCategoryId);
            Controls.Add(comboMainCategoryId);
            Controls.Add(labelCategoryName);
            Controls.Add(labelQuantity);
            Controls.Add(labelTotal);
            Controls.Add(txtTotal);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "ProductSaleForm";
            Size = new Size(1065, 500);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageCategoryDetail.ResumeLayout(false);
            tabPageCategoryDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button2;
        private Button button3;
    }
}

