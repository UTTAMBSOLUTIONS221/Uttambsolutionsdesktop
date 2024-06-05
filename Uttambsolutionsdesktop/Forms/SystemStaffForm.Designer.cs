namespace Uttambsolutionsdesktop.Forms
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
            // Adding all the new controls for SystemStaff properties
            labelFirstName = new Label();
            txtFirstName = new TextBox();
            labelLastName = new Label();
            txtLastName = new TextBox();
            labelPhonenumber = new Label();
            txtPhonenumber = new TextBox();
            labelUsername = new Label();
            txtUsername = new TextBox();
            labelEmailaddress = new Label();
            txtEmailaddress = new TextBox();
            labelRoleid = new Label();
            txtRoleid = new TextBox();

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
            tabPageStaffDetail.Controls.Add(labelFirstName);
            tabPageStaffDetail.Controls.Add(txtFirstName);
            tabPageStaffDetail.Controls.Add(labelLastName);
            tabPageStaffDetail.Controls.Add(txtLastName);
            tabPageStaffDetail.Controls.Add(labelPhonenumber);
            tabPageStaffDetail.Controls.Add(txtPhonenumber);
            tabPageStaffDetail.Controls.Add(labelUsername);
            tabPageStaffDetail.Controls.Add(txtUsername);
            tabPageStaffDetail.Controls.Add(labelEmailaddress);
            tabPageStaffDetail.Controls.Add(txtEmailaddress);
            tabPageStaffDetail.Controls.Add(labelRoleid);
            tabPageStaffDetail.Controls.Add(txtRoleid);
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
            // txtUserId
            // 
            txtUserId.Location = new Point(281, 265);
            txtUserId.Margin = new Padding(4, 3, 4, 3);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(314, 32);
            txtUserId.TabIndex = 12;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(154, 26);
            labelFirstName.Margin = new Padding(4, 0, 4, 0);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(110, 24);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(281, 26);
            txtFirstName.Margin = new Padding(4, 3, 4, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(314, 32);
            txtFirstName.TabIndex = 1;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(154, 65);
            labelLastName.Margin = new Padding(4, 0, 4, 0);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(110, 24);
            labelLastName.TabIndex = 2;
            labelLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(281, 65);
            txtLastName.Margin = new Padding(4, 3, 4, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(314, 32);
            txtLastName.TabIndex = 3;
            // 
            // labelPhonenumber
            // 
            labelPhonenumber.AutoSize = true;
            labelPhonenumber.Location = new Point(140, 105);
            labelPhonenumber.Margin = new Padding(4, 0, 4, 0);
            labelPhonenumber.Name = "labelPhonenumber";
            labelPhonenumber.Size = new Size(145, 24);
            labelPhonenumber.TabIndex = 4;
            labelPhonenumber.Text = "Phone Number";
            // 
            // txtPhonenumber
            // 
            txtPhonenumber.Location = new Point(281, 105);
            txtPhonenumber.Margin = new Padding(4, 3, 4, 3);
            txtPhonenumber.Name = "txtPhonenumber";
            txtPhonenumber.Size = new Size(314, 32);
            txtPhonenumber.TabIndex = 5;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(140, 145);
            labelUsername.Margin = new Padding(4, 0, 4, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(106, 24);
            labelUsername.TabIndex = 6;
            labelUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(281, 145);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(314, 32);
            txtUsername.TabIndex = 7;
            // 
            // labelEmailaddress
            // 
            labelEmailaddress.AutoSize = true;
            labelEmailaddress.Location = new Point(140, 185);
            labelEmailaddress.Margin = new Padding(4, 0, 4, 0);
            labelEmailaddress.Name = "labelEmailaddress";
            labelEmailaddress.Size = new Size(136, 24);
            labelEmailaddress.TabIndex = 8;
            labelEmailaddress.Text = "Email Address";
            // 
            // txtEmailaddress
            // 
            txtEmailaddress.Location = new Point(281, 185);
            txtEmailaddress.Margin = new Padding(4, 3, 4, 3);
            txtEmailaddress.Name = "txtEmailaddress";
            txtEmailaddress.Size = new Size(314, 32);
            txtEmailaddress.TabIndex = 9;
            // 
            // labelRoleid
            // 
            labelRoleid.AutoSize = true;
            labelRoleid.Location = new Point(140, 225);
            labelRoleid.Margin = new Padding(4, 0, 4, 0);
            labelRoleid.Name = "labelRoleid";
            labelRoleid.Size = new Size(78, 24);
            labelRoleid.TabIndex = 10;
            labelRoleid.Text = "Role ID";
            // 
            // txtRoleid
            // 
            txtRoleid.Location = new Point(281, 225);
            txtRoleid.Margin = new Padding(4, 3, 4, 3);
            txtRoleid.Name = "txtRoleid";
            txtRoleid.Size = new Size(314, 32);
            txtRoleid.TabIndex = 11;
            // 
            // SystemStaffForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 539);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SystemStaffForm";
            Text = "System Staff Form";
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
        private TextBox txtUserId;
        private Label labelFirstName;
        private TextBox txtFirstName;
        private Label labelLastName;
        private TextBox txtLastName;
        private Label labelPhonenumber;
        private TextBox txtPhonenumber;
        private Label labelUsername;
        private TextBox txtUsername;
        private Label labelEmailaddress;
        private TextBox txtEmailaddress;
        private Label labelRoleid;
        private TextBox txtRoleid;
    }
}
