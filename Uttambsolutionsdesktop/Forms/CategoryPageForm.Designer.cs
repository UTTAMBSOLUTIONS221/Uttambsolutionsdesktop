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
            tabPageThirdCategoryDetail = new TabPage();
            comboThirdFirstCategoryId = new ComboBox();
            txtThirdCategoryName = new TextBox();
            txtThirdCategoryId = new TextBox();
            label7 = new Label();
            label5 = new Label();
            btnSaveThird = new Button();
            btnCancelThird = new Button();
            tabPageFirstCategoryDetail = new TabPage();
            comboFirstMainCategoryId = new ComboBox();
            txtFirstCategoryName = new TextBox();
            txtFirstCategoryId = new TextBox();
            label6 = new Label();
            label4 = new Label();
            btnSaveFirst = new Button();
            btnCancelFirst = new Button();
            tabPageMainCategoryDetail = new TabPage();
            txtMainCategoryName = new TextBox();
            txtMainCategoryId = new TextBox();
            label3 = new Label();
            btnSaveMain = new Button();
            btnCancelMain = new Button();
            tabPageCategoryList = new TabPage();
            btnAddNewFirst = new Button();
            btnEditFirst = new Button();
            btnDeleteFirst = new Button();
            btnAddNewMain = new Button();
            btnEditMain = new Button();
            btnDeleteMain = new Button();
            dataGridViewFirst = new DataGridView();
            dataGridViewMain = new DataGridView();
            tabControl1 = new TabControl();
            panel1.SuspendLayout();
            tabPageThirdCategoryDetail.SuspendLayout();
            tabPageFirstCategoryDetail.SuspendLayout();
            tabPageMainCategoryDetail.SuspendLayout();
            tabPageCategoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFirst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).BeginInit();
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
            // tabPageThirdCategoryDetail
            // 
            tabPageThirdCategoryDetail.Controls.Add(btnCancelThird);
            tabPageThirdCategoryDetail.Controls.Add(btnSaveThird);
            tabPageThirdCategoryDetail.Controls.Add(label5);
            tabPageThirdCategoryDetail.Controls.Add(label7);
            tabPageThirdCategoryDetail.Controls.Add(txtThirdCategoryId);
            tabPageThirdCategoryDetail.Controls.Add(txtThirdCategoryName);
            tabPageThirdCategoryDetail.Controls.Add(comboThirdFirstCategoryId);
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
            // comboThirdFirstCategoryId
            // 
            comboThirdFirstCategoryId.Location = new Point(67, 80);
            comboThirdFirstCategoryId.Margin = new Padding(4, 3, 4, 3);
            comboThirdFirstCategoryId.Name = "comboThirdFirstCategoryId";
            comboThirdFirstCategoryId.Size = new Size(376, 32);
            comboThirdFirstCategoryId.TabIndex = 16;
            // 
            // txtThirdCategoryName
            // 
            txtThirdCategoryName.Location = new Point(63, 138);
            txtThirdCategoryName.Margin = new Padding(4, 3, 4, 3);
            txtThirdCategoryName.Name = "txtThirdCategoryName";
            txtThirdCategoryName.Size = new Size(380, 29);
            txtThirdCategoryName.TabIndex = 12;
            // 
            // txtThirdCategoryId
            // 
            txtThirdCategoryId.Location = new Point(232, 25);
            txtThirdCategoryId.Name = "txtThirdCategoryId";
            txtThirdCategoryId.Size = new Size(211, 29);
            txtThirdCategoryId.TabIndex = 16;
            txtThirdCategoryId.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(67, 34);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 13;
            label7.Text = "First Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(67, 115);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(162, 20);
            label5.TabIndex = 13;
            label5.Text = "Third Category Name:";
            // 
            // btnSaveThird
            // 
            btnSaveThird.Location = new Point(63, 186);
            btnSaveThird.Margin = new Padding(4, 3, 4, 3);
            btnSaveThird.Name = "btnSaveThird";
            btnSaveThird.Size = new Size(192, 44);
            btnSaveThird.TabIndex = 14;
            btnSaveThird.Text = "Save";
            btnSaveThird.UseVisualStyleBackColor = true;
            // 
            // btnCancelThird
            // 
            btnCancelThird.Location = new Point(263, 186);
            btnCancelThird.Margin = new Padding(4, 3, 4, 3);
            btnCancelThird.Name = "btnCancelThird";
            btnCancelThird.Size = new Size(180, 44);
            btnCancelThird.TabIndex = 15;
            btnCancelThird.Text = "Cancel";
            btnCancelThird.UseVisualStyleBackColor = true;
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
            // comboFirstMainCategoryId
            // 
            comboFirstMainCategoryId.Location = new Point(67, 55);
            comboFirstMainCategoryId.Margin = new Padding(4, 3, 4, 3);
            comboFirstMainCategoryId.Name = "comboFirstMainCategoryId";
            comboFirstMainCategoryId.Size = new Size(376, 32);
            comboFirstMainCategoryId.TabIndex = 16;
            // 
            // txtFirstCategoryName
            // 
            txtFirstCategoryName.Location = new Point(63, 121);
            txtFirstCategoryName.Margin = new Padding(4, 3, 4, 3);
            txtFirstCategoryName.Name = "txtFirstCategoryName";
            txtFirstCategoryName.Size = new Size(380, 29);
            txtFirstCategoryName.TabIndex = 12;
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
            // txtMainCategoryName
            // 
            txtMainCategoryName.Location = new Point(63, 74);
            txtMainCategoryName.Margin = new Padding(4, 3, 4, 3);
            txtMainCategoryName.Name = "txtMainCategoryName";
            txtMainCategoryName.Size = new Size(380, 29);
            txtMainCategoryName.TabIndex = 12;
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
            // btnAddNewMain
            // 
            btnAddNewMain.Location = new Point(22, 236);
            btnAddNewMain.Margin = new Padding(4, 3, 4, 3);
            btnAddNewMain.Name = "btnAddNewMain";
            btnAddNewMain.Size = new Size(71, 25);
            btnAddNewMain.TabIndex = 2;
            btnAddNewMain.Text = "Add New";
            btnAddNewMain.UseVisualStyleBackColor = true;
            // 
            // btnEditMain
            // 
            btnEditMain.Location = new Point(101, 236);
            btnEditMain.Margin = new Padding(4, 3, 4, 3);
            btnEditMain.Name = "btnEditMain";
            btnEditMain.Size = new Size(68, 25);
            btnEditMain.TabIndex = 3;
            btnEditMain.Text = "Edit";
            btnEditMain.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMain
            // 
            btnDeleteMain.Location = new Point(177, 236);
            btnDeleteMain.Margin = new Padding(4, 3, 4, 3);
            btnDeleteMain.Name = "btnDeleteMain";
            btnDeleteMain.Size = new Size(70, 25);
            btnDeleteMain.TabIndex = 4;
            btnDeleteMain.Text = "Delete";
            btnDeleteMain.UseVisualStyleBackColor = true;
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
            tabPageThirdCategoryDetail.ResumeLayout(false);
            tabPageThirdCategoryDetail.PerformLayout();
            tabPageFirstCategoryDetail.ResumeLayout(false);
            tabPageFirstCategoryDetail.PerformLayout();
            tabPageMainCategoryDetail.ResumeLayout(false);
            tabPageMainCategoryDetail.PerformLayout();
            tabPageCategoryList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFirst).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TabPage tabPageThirdCategoryDetail;
        private Button btnCancelThird;
        private Button btnSaveThird;
        private Label label5;
        private Label label7;
        private TextBox txtThirdCategoryId;
        private TextBox txtThirdCategoryName;
        private ComboBox comboThirdFirstCategoryId;
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
