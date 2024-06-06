using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Uttambsolutionsdesktop.Forms
{
    partial class CategoryPageForm
    {
        private Label label1;
        private Panel panel1;

        public CategoryPageForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            tabPageFirstCategoryDetail = new TabPage();
            btnCancelFirst = new Button();
            btnSaveFirst = new Button();
            label4 = new Label();
            label6 = new Label();
            txtFirstCategoryId = new TextBox();
            txtFirstCategoryName = new TextBox();
            comboFirstMainCategoryId = new ComboBox();
            tabPageMainCategoryDetail = new TabPage();
            btnCancelMain = new Button();
            btnSaveMain = new Button();
            label3 = new Label();
            txtMainCategoryId = new TextBox();
            txtMainCategoryName = new TextBox();
            tabPageCategoryList = new TabPage();
            dataGridViewMain = new DataGridView();
            dataGridViewFirst = new DataGridView();
            btnDeleteMain = new Button();
            btnEditMain = new Button();
            btnAddNewMain = new Button();
            btnDeleteFirst = new Button();
            btnEditFirst = new Button();
            btnAddNewFirst = new Button();
            tabControl1 = new TabControl();
            panel1.SuspendLayout();
            tabPageFirstCategoryDetail.SuspendLayout();
            tabPageMainCategoryDetail.SuspendLayout();
            tabPageCategoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFirst).BeginInit();
            tabControl1.SuspendLayout();
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
            label1.Text = "PRODUCT CATEGORIES";
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
            // tabPageFirstCategoryDetail
            // 
            tabPageFirstCategoryDetail.Controls.Add(btnCancelFirst);
            tabPageFirstCategoryDetail.Controls.Add(btnSaveFirst);
            tabPageFirstCategoryDetail.Controls.Add(label4);
            tabPageFirstCategoryDetail.Controls.Add(label6);
            tabPageFirstCategoryDetail.Controls.Add(txtFirstCategoryId);
            tabPageFirstCategoryDetail.Controls.Add(txtFirstCategoryName);
            tabPageFirstCategoryDetail.Controls.Add(comboFirstMainCategoryId);
            tabPageFirstCategoryDetail.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageFirstCategoryDetail.Location = new Point(4, 24);
            tabPageFirstCategoryDetail.Margin = new Padding(4, 3, 4, 3);
            tabPageFirstCategoryDetail.Name = "tabPageFirstCategoryDetail";
            tabPageFirstCategoryDetail.Padding = new Padding(4, 3, 4, 3);
            tabPageFirstCategoryDetail.Size = new Size(1033, 446);
            tabPageFirstCategoryDetail.TabIndex = 1;
            tabPageFirstCategoryDetail.Text = "First Category Detail";
            tabPageFirstCategoryDetail.UseVisualStyleBackColor = true;
            // 
            // btnCancelFirst
            // 
            btnCancelFirst.Location = new Point(263, 172);
            btnCancelFirst.Margin = new Padding(4, 3, 4, 3);
            btnCancelFirst.Name = "btnCancelFirst";
            btnCancelFirst.Size = new Size(180, 44);
            btnCancelFirst.TabIndex = 15;
            btnCancelFirst.Text = "Cancel";
            btnCancelFirst.UseVisualStyleBackColor = true;
            // 
            // btnSaveFirst
            // 
            btnSaveFirst.Location = new Point(63, 172);
            btnSaveFirst.Margin = new Padding(4, 3, 4, 3);
            btnSaveFirst.Name = "btnSaveFirst";
            btnSaveFirst.Size = new Size(192, 44);
            btnSaveFirst.TabIndex = 14;
            btnSaveFirst.Text = "Save";
            btnSaveFirst.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(67, 98);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(158, 20);
            label4.TabIndex = 13;
            label4.Text = "First Category Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(67, 29);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 13;
            label6.Text = "Main Category:";
            // 
            // txtFirstCategoryId
            // 
            txtFirstCategoryId.Location = new Point(281, 20);
            txtFirstCategoryId.Margin = new Padding(4, 3, 4, 3);
            txtFirstCategoryId.Name = "txtFirstCategoryId";
            txtFirstCategoryId.Size = new Size(162, 29);
            txtFirstCategoryId.TabIndex = 16;
            txtFirstCategoryId.Visible = false;
            // 
            // txtFirstCategoryName
            // 
            txtFirstCategoryName.Location = new Point(63, 121);
            txtFirstCategoryName.Margin = new Padding(4, 3, 4, 3);
            txtFirstCategoryName.Name = "txtFirstCategoryName";
            txtFirstCategoryName.Size = new Size(380, 29);
            txtFirstCategoryName.TabIndex = 12;
            // 
            // comboFirstMainCategoryId
            // 
            comboFirstMainCategoryId.Location = new Point(67, 55);
            comboFirstMainCategoryId.Margin = new Padding(4, 3, 4, 3);
            comboFirstMainCategoryId.Name = "comboFirstMainCategoryId";
            comboFirstMainCategoryId.Size = new Size(376, 32);
            comboFirstMainCategoryId.TabIndex = 16;
            // 
            // tabPageMainCategoryDetail
            // 
            tabPageMainCategoryDetail.Controls.Add(btnCancelMain);
            tabPageMainCategoryDetail.Controls.Add(btnSaveMain);
            tabPageMainCategoryDetail.Controls.Add(label3);
            tabPageMainCategoryDetail.Controls.Add(txtMainCategoryId);
            tabPageMainCategoryDetail.Controls.Add(txtMainCategoryName);
            tabPageMainCategoryDetail.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageMainCategoryDetail.Location = new Point(4, 24);
            tabPageMainCategoryDetail.Margin = new Padding(4, 3, 4, 3);
            tabPageMainCategoryDetail.Name = "tabPageMainCategoryDetail";
            tabPageMainCategoryDetail.Padding = new Padding(4, 3, 4, 3);
            tabPageMainCategoryDetail.Size = new Size(1033, 446);
            tabPageMainCategoryDetail.TabIndex = 1;
            tabPageMainCategoryDetail.Text = "Main Category Detail";
            tabPageMainCategoryDetail.UseVisualStyleBackColor = true;
            // 
            // btnCancelMain
            // 
            btnCancelMain.Location = new Point(263, 140);
            btnCancelMain.Margin = new Padding(4, 3, 4, 3);
            btnCancelMain.Name = "btnCancelMain";
            btnCancelMain.Size = new Size(180, 44);
            btnCancelMain.TabIndex = 15;
            btnCancelMain.Text = "Cancel";
            btnCancelMain.UseVisualStyleBackColor = true;
            // 
            // btnSaveMain
            // 
            btnSaveMain.Location = new Point(63, 140);
            btnSaveMain.Margin = new Padding(4, 3, 4, 3);
            btnSaveMain.Name = "btnSaveMain";
            btnSaveMain.Size = new Size(192, 44);
            btnSaveMain.TabIndex = 14;
            btnSaveMain.Text = "Save";
            btnSaveMain.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 54);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(161, 20);
            label3.TabIndex = 13;
            label3.Text = "Main Category Name:";
            // 
            // txtMainCategoryId
            // 
            txtMainCategoryId.Location = new Point(63, 20);
            txtMainCategoryId.Margin = new Padding(4, 3, 4, 3);
            txtMainCategoryId.Name = "txtMainCategoryId";
            txtMainCategoryId.Size = new Size(380, 29);
            txtMainCategoryId.TabIndex = 16;
            txtMainCategoryId.Visible = false;
            // 
            // txtMainCategoryName
            // 
            txtMainCategoryName.Location = new Point(63, 74);
            txtMainCategoryName.Margin = new Padding(4, 3, 4, 3);
            txtMainCategoryName.Name = "txtMainCategoryName";
            txtMainCategoryName.Size = new Size(380, 29);
            txtMainCategoryName.TabIndex = 12;
            // 
            // tabPageCategoryList
            // 
            tabPageCategoryList.Controls.Add(dataGridViewMain);
            tabPageCategoryList.Controls.Add(dataGridViewFirst);
            tabPageCategoryList.Controls.Add(btnDeleteMain);
            tabPageCategoryList.Controls.Add(btnEditMain);
            tabPageCategoryList.Controls.Add(btnAddNewMain);
            tabPageCategoryList.Controls.Add(btnDeleteFirst);
            tabPageCategoryList.Controls.Add(btnEditFirst);
            tabPageCategoryList.Controls.Add(btnAddNewFirst);
            tabPageCategoryList.Location = new Point(4, 24);
            tabPageCategoryList.Margin = new Padding(4, 3, 4, 3);
            tabPageCategoryList.Name = "tabPageCategoryList";
            tabPageCategoryList.Padding = new Padding(4, 3, 4, 3);
            tabPageCategoryList.Size = new Size(1033, 446);
            tabPageCategoryList.TabIndex = 0;
            tabPageCategoryList.Text = "Category List";
            tabPageCategoryList.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMain
            // 
            dataGridViewMain.AllowUserToAddRows = false;
            dataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMain.Location = new Point(22, 18);
            dataGridViewMain.Margin = new Padding(4, 3, 4, 3);
            dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewMain.Size = new Size(428, 200);
            dataGridViewMain.TabIndex = 6;
            // 
            // dataGridViewFirst
            // 
            dataGridViewFirst.AllowUserToAddRows = false;
            dataGridViewFirst.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFirst.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFirst.Location = new Point(458, 18);
            dataGridViewFirst.Margin = new Padding(4, 3, 4, 3);
            dataGridViewFirst.Name = "dataGridViewFirst";
            dataGridViewFirst.Size = new Size(567, 200);
            dataGridViewFirst.TabIndex = 7;
            // 
            // btnDeleteMain
            // 
            btnDeleteMain.Location = new Point(231, 235);
            btnDeleteMain.Margin = new Padding(4, 3, 4, 3);
            btnDeleteMain.Name = "btnDeleteMain";
            btnDeleteMain.Size = new Size(70, 25);
            btnDeleteMain.TabIndex = 4;
            btnDeleteMain.Text = "Delete";
            btnDeleteMain.UseVisualStyleBackColor = true;
            // 
            // btnEditMain
            // 
            btnEditMain.Location = new Point(155, 235);
            btnEditMain.Margin = new Padding(4, 3, 4, 3);
            btnEditMain.Name = "btnEditMain";
            btnEditMain.Size = new Size(68, 25);
            btnEditMain.TabIndex = 3;
            btnEditMain.Text = "Edit";
            btnEditMain.UseVisualStyleBackColor = true;
            // 
            // btnAddNewMain
            // 
            btnAddNewMain.Location = new Point(76, 235);
            btnAddNewMain.Margin = new Padding(4, 3, 4, 3);
            btnAddNewMain.Name = "btnAddNewMain";
            btnAddNewMain.Size = new Size(71, 25);
            btnAddNewMain.TabIndex = 2;
            btnAddNewMain.Text = "Add New";
            btnAddNewMain.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFirst
            // 
            btnDeleteFirst.Location = new Point(791, 237);
            btnDeleteFirst.Margin = new Padding(4, 3, 4, 3);
            btnDeleteFirst.Name = "btnDeleteFirst";
            btnDeleteFirst.Size = new Size(82, 25);
            btnDeleteFirst.TabIndex = 9;
            btnDeleteFirst.Text = "Delete";
            btnDeleteFirst.UseVisualStyleBackColor = true;
            // 
            // btnEditFirst
            // 
            btnEditFirst.Location = new Point(701, 236);
            btnEditFirst.Margin = new Padding(4, 3, 4, 3);
            btnEditFirst.Name = "btnEditFirst";
            btnEditFirst.Size = new Size(82, 25);
            btnEditFirst.TabIndex = 10;
            btnEditFirst.Text = "Edit";
            btnEditFirst.UseVisualStyleBackColor = true;
            // 
            // btnAddNewFirst
            // 
            btnAddNewFirst.Location = new Point(609, 235);
            btnAddNewFirst.Margin = new Padding(4, 3, 4, 3);
            btnAddNewFirst.Name = "btnAddNewFirst";
            btnAddNewFirst.Size = new Size(84, 25);
            btnAddNewFirst.TabIndex = 11;
            btnAddNewFirst.Text = "Add New";
            btnAddNewFirst.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategoryList);
            tabControl1.Controls.Add(tabPageMainCategoryDetail);
            tabControl1.Controls.Add(tabPageFirstCategoryDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 65);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1041, 474);
            tabControl1.TabIndex = 2;
            // 
            // CategoryPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoryPageForm";
            Size = new Size(1041, 539);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageFirstCategoryDetail.ResumeLayout(false);
            tabPageFirstCategoryDetail.PerformLayout();
            tabPageMainCategoryDetail.ResumeLayout(false);
            tabPageMainCategoryDetail.PerformLayout();
            tabPageCategoryList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFirst).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Label label5;
        private TabPage tabPageFirstCategoryDetail;
        private Button btnCancelFirst;
        private Button btnSaveFirst;
        private Label label4;
        private Label label6;
        private TextBox txtFirstCategoryId;
        private TextBox txtFirstCategoryName;
        private ComboBox comboFirstMainCategoryId;
        private TabPage tabPageMainCategoryDetail;
        private Button btnCancelMain;
        private Button btnSaveMain;
        private Label label3;
        private TextBox txtMainCategoryId;
        private TextBox txtMainCategoryName;
        private TabPage tabPageCategoryList;
        private DataGridView dataGridViewMain;
        private DataGridView dataGridViewFirst;
        private Button btnDeleteMain;
        private Button btnEditMain;
        private Button btnAddNewMain;
        private Button btnDeleteFirst;
        private Button btnEditFirst;
        private Button btnAddNewFirst;
        private TabControl tabControl1;
    }
}
