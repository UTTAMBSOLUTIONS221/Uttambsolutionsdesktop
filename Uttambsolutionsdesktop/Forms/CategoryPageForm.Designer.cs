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
        private TabControl tabControl1;
        private TabPage tabPageCategoryList;
        private DataGridView dataGridViewMain;
        private DataGridView dataGridViewFirst;
        private DataGridView dataGridViewThird;
        private Label label2;
        private Button btnDeleteMain;
        private Button btnEditMain;
        private Button btnAddNewMain;
        private Button btnDeleteFirst;
        private Button btnEditFirst;
        private Button btnAddNewFirst;
        private Button btnDeleteThird;
        private Button btnEditThird;
        private Button btnAddNewThird;
        private TabPage tabPageCategoryDetail;
        private Button btnCancel;
        private Button btnSave;
        private Label label3;
        private TextBox txtCategoryName;
        private TextBox txtCategoryId;

        public CategoryPageForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPageCategoryList = new TabPage();
            dataGridViewMain = new DataGridView();
            dataGridViewFirst = new DataGridView();
            dataGridViewThird = new DataGridView();
            label2 = new Label();
            btnDeleteMain = new Button();
            btnEditMain = new Button();
            btnAddNewMain = new Button();
            btnDeleteFirst = new Button();
            btnEditFirst = new Button();
            btnAddNewFirst = new Button();
            btnDeleteThird = new Button();
            btnEditThird = new Button();
            btnAddNewThird = new Button();
            tabPageCategoryDetail = new TabPage();
            btnCancel = new Button();
            btnSave = new Button();
            label3 = new Label();
            txtCategoryName = new TextBox();
            txtCategoryId = new TextBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageCategoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFirst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewThird).BeginInit();
            tabPageCategoryDetail.SuspendLayout();
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategoryList);
            tabControl1.Controls.Add(tabPageCategoryDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 65);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1041, 474);
            tabControl1.TabIndex = 2;
            // 
            // tabPageCategoryList
            // 
            tabPageCategoryList.Controls.Add(dataGridViewMain);
            tabPageCategoryList.Controls.Add(dataGridViewFirst);
            tabPageCategoryList.Controls.Add(dataGridViewThird);
            tabPageCategoryList.Controls.Add(label2);
            tabPageCategoryList.Controls.Add(btnDeleteMain);
            tabPageCategoryList.Controls.Add(btnEditMain);
            tabPageCategoryList.Controls.Add(btnAddNewMain);
            tabPageCategoryList.Controls.Add(btnDeleteFirst);
            tabPageCategoryList.Controls.Add(btnEditFirst);
            tabPageCategoryList.Controls.Add(btnAddNewFirst);
            tabPageCategoryList.Controls.Add(btnDeleteThird);
            tabPageCategoryList.Controls.Add(btnEditThird);
            tabPageCategoryList.Controls.Add(btnAddNewThird);
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
            dataGridViewMain.Location = new Point(44, 18);
            dataGridViewMain.Margin = new Padding(4, 3, 4, 3);
            dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewMain.Size = new Size(306, 200);
            dataGridViewMain.TabIndex = 6;
            // 
            // dataGridViewFirst
            // 
            dataGridViewFirst.AllowUserToAddRows = false;
            dataGridViewFirst.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFirst.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFirst.Location = new Point(366, 18);
            dataGridViewFirst.Margin = new Padding(4, 3, 4, 3);
            dataGridViewFirst.Name = "dataGridViewFirst";
            dataGridViewFirst.Size = new Size(321, 200);
            dataGridViewFirst.TabIndex = 7;
            // 
            // dataGridViewThird
            // 
            dataGridViewThird.AllowUserToAddRows = false;
            dataGridViewThird.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewThird.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewThird.Location = new Point(703, 18);
            dataGridViewThird.Margin = new Padding(4, 3, 4, 3);
            dataGridViewThird.Name = "dataGridViewThird";
            dataGridViewThird.Size = new Size(322, 200);
            dataGridViewThird.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1007, 215);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 5;
            // 
            // btnDeleteMain
            // 
            btnDeleteMain.Location = new Point(254, 236);
            btnDeleteMain.Margin = new Padding(4, 3, 4, 3);
            btnDeleteMain.Name = "btnDeleteMain";
            btnDeleteMain.Size = new Size(74, 25);
            btnDeleteMain.TabIndex = 4;
            btnDeleteMain.Text = "Delete";
            btnDeleteMain.UseVisualStyleBackColor = true;
            // 
            // btnEditMain
            // 
            btnEditMain.Location = new Point(164, 236);
            btnEditMain.Margin = new Padding(4, 3, 4, 3);
            btnEditMain.Name = "btnEditMain";
            btnEditMain.Size = new Size(74, 25);
            btnEditMain.TabIndex = 3;
            btnEditMain.Text = "Edit";
            btnEditMain.UseVisualStyleBackColor = true;
            // 
            // btnAddNewMain
            // 
            btnAddNewMain.Location = new Point(54, 236);
            btnAddNewMain.Margin = new Padding(4, 3, 4, 3);
            btnAddNewMain.Name = "btnAddNewMain";
            btnAddNewMain.Size = new Size(76, 25);
            btnAddNewMain.TabIndex = 2;
            btnAddNewMain.Text = "Add New";
            btnAddNewMain.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFirst
            // 
            btnDeleteFirst.Location = new Point(577, 236);
            btnDeleteFirst.Margin = new Padding(4, 3, 4, 3);
            btnDeleteFirst.Name = "btnDeleteFirst";
            btnDeleteFirst.Size = new Size(74, 25);
            btnDeleteFirst.TabIndex = 9;
            btnDeleteFirst.Text = "Delete";
            btnDeleteFirst.UseVisualStyleBackColor = true;
            // 
            // btnEditFirst
            // 
            btnEditFirst.Location = new Point(478, 236);
            btnEditFirst.Margin = new Padding(4, 3, 4, 3);
            btnEditFirst.Name = "btnEditFirst";
            btnEditFirst.Size = new Size(74, 25);
            btnEditFirst.TabIndex = 10;
            btnEditFirst.Text = "Edit";
            btnEditFirst.UseVisualStyleBackColor = true;
            // 
            // btnAddNewFirst
            // 
            btnAddNewFirst.Location = new Point(386, 236);
            btnAddNewFirst.Margin = new Padding(4, 3, 4, 3);
            btnAddNewFirst.Name = "btnAddNewFirst";
            btnAddNewFirst.Size = new Size(76, 25);
            btnAddNewFirst.TabIndex = 11;
            btnAddNewFirst.Text = "Add New";
            btnAddNewFirst.UseVisualStyleBackColor = true;
            // 
            // btnDeleteThird
            // 
            btnDeleteThird.Location = new Point(935, 236);
            btnDeleteThird.Margin = new Padding(4, 3, 4, 3);
            btnDeleteThird.Name = "btnDeleteThird";
            btnDeleteThird.Size = new Size(74, 25);
            btnDeleteThird.TabIndex = 14;
            btnDeleteThird.Text = "Delete";
            btnDeleteThird.UseVisualStyleBackColor = true;
            // 
            // btnEditThird
            // 
            btnEditThird.Location = new Point(845, 236);
            btnEditThird.Margin = new Padding(4, 3, 4, 3);
            btnEditThird.Name = "btnEditThird";
            btnEditThird.Size = new Size(74, 25);
            btnEditThird.TabIndex = 15;
            btnEditThird.Text = "Edit";
            btnEditThird.UseVisualStyleBackColor = true;
            // 
            // btnAddNewThird
            // 
            btnAddNewThird.Location = new Point(753, 236);
            btnAddNewThird.Margin = new Padding(4, 3, 4, 3);
            btnAddNewThird.Name = "btnAddNewThird";
            btnAddNewThird.Size = new Size(76, 25);
            btnAddNewThird.TabIndex = 16;
            btnAddNewThird.Text = "Add New";
            btnAddNewThird.UseVisualStyleBackColor = true;
            // 
            // tabPageCategoryDetail
            // 
            tabPageCategoryDetail.Controls.Add(btnCancel);
            tabPageCategoryDetail.Controls.Add(btnSave);
            tabPageCategoryDetail.Controls.Add(label3);
            tabPageCategoryDetail.Controls.Add(txtCategoryName);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 54);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 13;
            label3.Text = "Category Name:";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(63, 74);
            txtCategoryName.Margin = new Padding(4, 3, 4, 3);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(380, 29);
            txtCategoryName.TabIndex = 12;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(63, 20);
            txtCategoryId.Margin = new Padding(4, 3, 4, 3);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(100, 29);
            txtCategoryId.TabIndex = 16;
            txtCategoryId.Visible = false;
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
            tabControl1.ResumeLayout(false);
            tabPageCategoryList.ResumeLayout(false);
            tabPageCategoryList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFirst).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewThird).EndInit();
            tabPageCategoryDetail.ResumeLayout(false);
            tabPageCategoryDetail.PerformLayout();
            ResumeLayout(false);
        }
    }
}
