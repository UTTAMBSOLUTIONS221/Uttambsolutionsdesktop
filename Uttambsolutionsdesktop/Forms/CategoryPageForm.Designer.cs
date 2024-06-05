using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Uttambsolutionsdesktop.Forms
{
    partial class CategoryPageForm
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPageCategoryList;
        private DataGridView dataGridViewMain;
        private DataGridView dataGridViewFirst;
        private DataGridView dataGridViewThird;
        private Button btnDeleteMain;
        private Button btnEditMain;
        private Button btnAddNewMain;
        private Button btnDeleteFirst;
        private Button btnEditFirst;
        private Button btnAddNewFirst;
        private Button btnDeleteThird;
        private Button btnEditThird;
        private Button btnAddNewThird;
        private TabPage tabPageMainCategoryDetail;
        private TabPage tabPageFirstCategoryDetail;
        private TabPage tabPageThirdCategoryDetail;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtMainCategoryId;
        private TextBox txtMainCategoryName;
        private TextBox txtFirstCategoryId;
        private TextBox txtFirstCategoryName;
        private TextBox txtFirstMainCategoryId;
        private TextBox txtThirdCategoryId;
        private TextBox txtThirdCategoryName;
        private TextBox txtThirdFirstCategoryId;

        public CategoryPageForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tabControl1 = new TabControl();
            tabPageCategoryList = new TabPage();
            dataGridViewMain = new DataGridView();
            dataGridViewFirst = new DataGridView();
            dataGridViewThird = new DataGridView();
            btnDeleteMain = new Button();
            btnEditMain = new Button();
            btnAddNewMain = new Button();
            btnDeleteFirst = new Button();
            btnEditFirst = new Button();
            btnAddNewFirst = new Button();
            btnDeleteThird = new Button();
            btnEditThird = new Button();
            btnAddNewThird = new Button();
            tabPageMainCategoryDetail = new TabPage();
            btnCancel = new Button();
            btnSave = new Button();
            txtMainCategoryId = new TextBox();
            txtMainCategoryName = new TextBox();
            tabPageFirstCategoryDetail = new TabPage();
            txtFirstCategoryId = new TextBox();
            txtFirstCategoryName = new TextBox();
            txtFirstMainCategoryId = new TextBox();
            tabPageThirdCategoryDetail = new TabPage();
            txtThirdCategoryId = new TextBox();
            txtThirdCategoryName = new TextBox();
            txtThirdFirstCategoryId = new TextBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageCategoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFirst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewThird).BeginInit();
            tabPageMainCategoryDetail.SuspendLayout();
            tabPageFirstCategoryDetail.SuspendLayout();
            tabPageThirdCategoryDetail.SuspendLayout();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(938, 215);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 5;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(67, 54);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(158, 20);
            label4.TabIndex = 13;
            label4.Text = "First Category Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(67, 54);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(162, 20);
            label5.TabIndex = 13;
            label5.Text = "Third Category Name:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategoryList);
            tabControl1.Controls.Add(tabPageMainCategoryDetail);
            tabControl1.Controls.Add(tabPageFirstCategoryDetail);
            tabControl1.Controls.Add(tabPageThirdCategoryDetail);
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
            dataGridViewMain.Location = new Point(22, 18);
            dataGridViewMain.Margin = new Padding(4, 3, 4, 3);
            dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewMain.Size = new Size(332, 200);
            dataGridViewMain.TabIndex = 6;
            // 
            // dataGridViewFirst
            // 
            dataGridViewFirst.AllowUserToAddRows = false;
            dataGridViewFirst.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFirst.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFirst.Location = new Point(362, 18);
            dataGridViewFirst.Margin = new Padding(4, 3, 4, 3);
            dataGridViewFirst.Name = "dataGridViewFirst";
            dataGridViewFirst.Size = new Size(334, 200);
            dataGridViewFirst.TabIndex = 7;
            // 
            // dataGridViewThird
            // 
            dataGridViewThird.AllowUserToAddRows = false;
            dataGridViewThird.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewThird.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewThird.Location = new Point(704, 18);
            dataGridViewThird.Margin = new Padding(4, 3, 4, 3);
            dataGridViewThird.Name = "dataGridViewThird";
            dataGridViewThird.Size = new Size(321, 200);
            dataGridViewThird.TabIndex = 8;
            // 
            // btnDeleteMain
            // 
            btnDeleteMain.Location = new Point(214, 236);
            btnDeleteMain.Margin = new Padding(4, 3, 4, 3);
            btnDeleteMain.Name = "btnDeleteMain";
            btnDeleteMain.Size = new Size(82, 25);
            btnDeleteMain.TabIndex = 4;
            btnDeleteMain.Text = "Delete";
            btnDeleteMain.UseVisualStyleBackColor = true;
            // 
            // btnEditMain
            // 
            btnEditMain.Location = new Point(124, 236);
            btnEditMain.Margin = new Padding(4, 3, 4, 3);
            btnEditMain.Name = "btnEditMain";
            btnEditMain.Size = new Size(82, 25);
            btnEditMain.TabIndex = 3;
            btnEditMain.Text = "Edit";
            btnEditMain.UseVisualStyleBackColor = true;
            // 
            // btnAddNewMain
            // 
            btnAddNewMain.Location = new Point(28, 236);
            btnAddNewMain.Margin = new Padding(4, 3, 4, 3);
            btnAddNewMain.Name = "btnAddNewMain";
            btnAddNewMain.Size = new Size(84, 25);
            btnAddNewMain.TabIndex = 2;
            btnAddNewMain.Text = "Add New";
            btnAddNewMain.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFirst
            // 
            btnDeleteFirst.Location = new Point(560, 237);
            btnDeleteFirst.Margin = new Padding(4, 3, 4, 3);
            btnDeleteFirst.Name = "btnDeleteFirst";
            btnDeleteFirst.Size = new Size(82, 25);
            btnDeleteFirst.TabIndex = 9;
            btnDeleteFirst.Text = "Delete";
            btnDeleteFirst.UseVisualStyleBackColor = true;
            // 
            // btnEditFirst
            // 
            btnEditFirst.Location = new Point(470, 236);
            btnEditFirst.Margin = new Padding(4, 3, 4, 3);
            btnEditFirst.Name = "btnEditFirst";
            btnEditFirst.Size = new Size(82, 25);
            btnEditFirst.TabIndex = 10;
            btnEditFirst.Text = "Edit";
            btnEditFirst.UseVisualStyleBackColor = true;
            // 
            // btnAddNewFirst
            // 
            btnAddNewFirst.Location = new Point(378, 235);
            btnAddNewFirst.Margin = new Padding(4, 3, 4, 3);
            btnAddNewFirst.Name = "btnAddNewFirst";
            btnAddNewFirst.Size = new Size(84, 25);
            btnAddNewFirst.TabIndex = 11;
            btnAddNewFirst.Text = "Add New";
            btnAddNewFirst.UseVisualStyleBackColor = true;
            // 
            // btnDeleteThird
            // 
            btnDeleteThird.Location = new Point(924, 236);
            btnDeleteThird.Margin = new Padding(4, 3, 4, 3);
            btnDeleteThird.Name = "btnDeleteThird";
            btnDeleteThird.Size = new Size(82, 25);
            btnDeleteThird.TabIndex = 14;
            btnDeleteThird.Text = "Delete";
            btnDeleteThird.UseVisualStyleBackColor = true;
            // 
            // btnEditThird
            // 
            btnEditThird.Location = new Point(834, 236);
            btnEditThird.Margin = new Padding(4, 3, 4, 3);
            btnEditThird.Name = "btnEditThird";
            btnEditThird.Size = new Size(82, 25);
            btnEditThird.TabIndex = 15;
            btnEditThird.Text = "Edit";
            btnEditThird.UseVisualStyleBackColor = true;
            // 
            // btnAddNewThird
            // 
            btnAddNewThird.Location = new Point(732, 236);
            btnAddNewThird.Margin = new Padding(4, 3, 4, 3);
            btnAddNewThird.Name = "btnAddNewThird";
            btnAddNewThird.Size = new Size(84, 23);
            btnAddNewThird.TabIndex = 16;
            btnAddNewThird.Text = "Add New";
            btnAddNewThird.UseVisualStyleBackColor = true;
            // 
            // tabPageMainCategoryDetail
            // 
            tabPageMainCategoryDetail.Controls.Add(btnCancel);
            tabPageMainCategoryDetail.Controls.Add(btnSave);
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
            // btnCancel
            // 
            btnCancel.Location = new Point(263, 140);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(180, 44);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(63, 140);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(192, 44);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
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
            // tabPageFirstCategoryDetail
            // 
            tabPageFirstCategoryDetail.Controls.Add(btnCancel);
            tabPageFirstCategoryDetail.Controls.Add(btnSave);
            tabPageFirstCategoryDetail.Controls.Add(label4);
            tabPageFirstCategoryDetail.Controls.Add(txtFirstCategoryId);
            tabPageFirstCategoryDetail.Controls.Add(txtFirstCategoryName);
            tabPageFirstCategoryDetail.Controls.Add(txtFirstMainCategoryId);
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
            // txtFirstCategoryId
            // 
            txtFirstCategoryId.Location = new Point(281, 20);
            txtFirstCategoryId.Margin = new Padding(4, 3, 4, 3);
            txtFirstCategoryId.Name = "txtFirstCategoryId";
            txtFirstCategoryId.Size = new Size(162, 29);
            txtFirstCategoryId.TabIndex = 16;
            txtFirstCategoryId.Visible = true;
            // 
            // txtFirstCategoryName
            // 
            txtFirstCategoryName.Location = new Point(63, 74);
            txtFirstCategoryName.Margin = new Padding(4, 3, 4, 3);
            txtFirstCategoryName.Name = "txtFirstCategoryName";
            txtFirstCategoryName.Size = new Size(380, 29);
            txtFirstCategoryName.TabIndex = 12;
            // 
            // txtFirstMainCategoryId
            // 
            txtFirstMainCategoryId.Location = new Point(67, 20);
            txtFirstMainCategoryId.Margin = new Padding(4, 3, 4, 3);
            txtFirstMainCategoryId.Name = "txtFirstMainCategoryId";
            txtFirstMainCategoryId.Size = new Size(192, 29);
            txtFirstMainCategoryId.TabIndex = 16;
            txtFirstMainCategoryId.Visible = true;
            // 
            // tabPageThirdCategoryDetail
            // 
            tabPageThirdCategoryDetail.Controls.Add(btnCancel);
            tabPageThirdCategoryDetail.Controls.Add(btnSave);
            tabPageThirdCategoryDetail.Controls.Add(label5);
            tabPageThirdCategoryDetail.Controls.Add(txtThirdCategoryId);
            tabPageThirdCategoryDetail.Controls.Add(txtThirdCategoryName);
            tabPageThirdCategoryDetail.Controls.Add(txtThirdFirstCategoryId);
            tabPageThirdCategoryDetail.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageThirdCategoryDetail.Location = new Point(4, 24);
            tabPageThirdCategoryDetail.Margin = new Padding(4, 3, 4, 3);
            tabPageThirdCategoryDetail.Name = "tabPageThirdCategoryDetail";
            tabPageThirdCategoryDetail.Padding = new Padding(4, 3, 4, 3);
            tabPageThirdCategoryDetail.Size = new Size(1033, 446);
            tabPageThirdCategoryDetail.TabIndex = 1;
            tabPageThirdCategoryDetail.Text = "Third Category Detail";
            tabPageThirdCategoryDetail.UseVisualStyleBackColor = true;
            // 
            // txtThirdCategoryId
            // 
            txtThirdCategoryId.Location = new Point(63, 22);
            txtThirdCategoryId.Name = "txtThirdCategoryId";
            txtThirdCategoryId.Size = new Size(192, 29);
            txtThirdCategoryId.TabIndex = 16;
            txtFirstMainCategoryId.Visible = true;
            // 
            // txtThirdCategoryName
            // 
            txtThirdCategoryName.Location = new Point(63, 74);
            txtThirdCategoryName.Margin = new Padding(4, 3, 4, 3);
            txtThirdCategoryName.Name = "txtThirdCategoryName";
            txtThirdCategoryName.Size = new Size(380, 29);
            txtThirdCategoryName.TabIndex = 12;
            // 
            // txtThirdFirstCategoryId
            // 
            txtThirdFirstCategoryId.Location = new Point(263, 22);
            txtThirdFirstCategoryId.Margin = new Padding(4, 3, 4, 3);
            txtThirdFirstCategoryId.Name = "txtThirdFirstCategoryId";
            txtThirdFirstCategoryId.Size = new Size(180, 29);
            txtThirdFirstCategoryId.TabIndex = 16;
            txtThirdFirstCategoryId.Visible = true;
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
            tabPageMainCategoryDetail.ResumeLayout(false);
            tabPageMainCategoryDetail.PerformLayout();
            tabPageFirstCategoryDetail.ResumeLayout(false);
            tabPageFirstCategoryDetail.PerformLayout();
            tabPageThirdCategoryDetail.ResumeLayout(false);
            tabPageThirdCategoryDetail.PerformLayout();
            ResumeLayout(false);
        }
    }
}
