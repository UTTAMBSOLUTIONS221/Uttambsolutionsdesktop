namespace Uttambsolutionsdesktop.Forms
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnToggleMenu;
        private System.Windows.Forms.Panel contentWrapper;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnStaffsList;
        private System.Windows.Forms.Button btnProductManagement;
        private System.Windows.Forms.Panel panelSettingsSubmenu;
        private System.Windows.Forms.Panel panelProductManagementSubmenu;
        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.Button btnCategoryList;
        private System.Windows.Forms.Button btnSalesList;

        private void InitializeComponent()
        {
            panelMenu = new Panel();
            panelProductManagementSubmenu = new Panel();
            btnSalesList = new Button();
            btnProductList = new Button();
            btnCategoryList = new Button();
            btnProductManagement = new Button();
            panelSettingsSubmenu = new Panel();
            btnSettings = new Button();
            btnStaffsList = new Button();
            btnDashboard = new Button();
            btnToggleMenu = new Button();
            contentWrapper = new Panel();
            panelMenu.SuspendLayout();
            panelProductManagementSubmenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(panelProductManagementSubmenu);
            panelMenu.Controls.Add(btnProductManagement);
            panelMenu.Controls.Add(panelSettingsSubmenu);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(4, 3, 4, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Padding = new Padding(0, 40, 0, 0);
            panelMenu.Size = new Size(131, 692);
            panelMenu.TabIndex = 0;
            // 
            // panelSettingsSubmenu
            // 
            panelSettingsSubmenu.BackColor = Color.FromArgb(35, 32, 39);
            panelSettingsSubmenu.Controls.Add(btnStaffsList);
            panelSettingsSubmenu.Dock = DockStyle.Top;
            panelSettingsSubmenu.Location = new Point(0, 283);
            panelSettingsSubmenu.Margin = new Padding(4, 3, 4, 3);
            panelSettingsSubmenu.Name = "panelSettingsSubmenu";
            panelSettingsSubmenu.Size = new Size(131, 114);
            panelSettingsSubmenu.TabIndex = 0;
            panelSettingsSubmenu.Visible = false;
            // 
            // panelProductManagementSubmenu
            // 
            panelProductManagementSubmenu.BackColor = Color.FromArgb(35, 32, 39);
            panelProductManagementSubmenu.Controls.Add(btnSalesList);
            panelProductManagementSubmenu.Controls.Add(btnProductList);
            panelProductManagementSubmenu.Controls.Add(btnCategoryList);
            panelProductManagementSubmenu.Dock = DockStyle.Top;
            panelProductManagementSubmenu.Location = new Point(0, 283);
            panelProductManagementSubmenu.Margin = new Padding(4, 3, 4, 3);
            panelProductManagementSubmenu.Name = "panelProductManagementSubmenu";
            panelProductManagementSubmenu.Size = new Size(131, 114);
            panelProductManagementSubmenu.TabIndex = 0;
            panelProductManagementSubmenu.Visible = false;
            // 
            // btnSalesList
            // 
            btnSalesList.Dock = DockStyle.Top;
            btnSalesList.FlatAppearance.BorderSize = 0;
            btnSalesList.FlatStyle = FlatStyle.Flat;
            btnSalesList.ForeColor = Color.Gainsboro;
            btnSalesList.Location = new Point(0, 76);
            btnSalesList.Margin = new Padding(4, 3, 4, 3);
            btnSalesList.Name = "btnSalesList";
            btnSalesList.Size = new Size(131, 38);
            btnSalesList.TabIndex = 2;
            btnSalesList.Text = "Sales List";
            btnSalesList.Click += BtnSalesList_Click;
            // 
            // btnProductList
            // 
            btnProductList.Dock = DockStyle.Top;
            btnProductList.FlatAppearance.BorderSize = 0;
            btnProductList.FlatStyle = FlatStyle.Flat;
            btnProductList.ForeColor = Color.Gainsboro;
            btnProductList.Location = new Point(0, 38);
            btnProductList.Margin = new Padding(4, 3, 4, 3);
            btnProductList.Name = "btnProductList";
            btnProductList.Size = new Size(131, 38);
            btnProductList.TabIndex = 1;
            btnProductList.Text = "Product List";
            btnProductList.Click += BtnProductList_Click;
            // 
            // btnCategoryList
            // 
            btnCategoryList.Dock = DockStyle.Top;
            btnCategoryList.FlatAppearance.BorderSize = 0;
            btnCategoryList.FlatStyle = FlatStyle.Flat;
            btnCategoryList.ForeColor = Color.Gainsboro;
            btnCategoryList.Location = new Point(0, 0);
            btnCategoryList.Margin = new Padding(4, 3, 4, 3);
            btnCategoryList.Name = "btnCategoryList";
            btnCategoryList.Size = new Size(131, 38);
            btnCategoryList.TabIndex = 0;
            btnCategoryList.Text = "Category List";
            btnCategoryList.Click += BtnCategoryList_Click;
            // 
            // btnProductManagement
            // 
            btnProductManagement.Dock = DockStyle.Top;
            btnProductManagement.FlatAppearance.BorderSize = 0;
            btnProductManagement.FlatStyle = FlatStyle.Flat;
            btnProductManagement.ForeColor = Color.Gainsboro;
            btnProductManagement.Location = new Point(0, 242);
            btnProductManagement.Margin = new Padding(4, 3, 4, 3);
            btnProductManagement.Name = "btnProductManagement";
            btnProductManagement.Size = new Size(131, 41);
            btnProductManagement.TabIndex = 1;
            btnProductManagement.Text = "Warehouse";
            btnProductManagement.Click += BtnProductManagement_Click;
            // 
            // panelSettingsSubmenu
            // 
            panelSettingsSubmenu.BackColor = Color.FromArgb(35, 32, 39);
            panelSettingsSubmenu.Dock = DockStyle.Top;
            panelSettingsSubmenu.Location = new Point(0, 144);
            panelSettingsSubmenu.Margin = new Padding(4, 3, 4, 3);
            panelSettingsSubmenu.Name = "panelSettingsSubmenu";
            panelSettingsSubmenu.Size = new Size(131, 98);
            panelSettingsSubmenu.TabIndex = 2;
            panelSettingsSubmenu.Visible = false;
            // 
            // btnStaffsList
            // 
            btnStaffsList.Dock = DockStyle.Top;
            btnStaffsList.FlatAppearance.BorderSize = 0;
            btnStaffsList.FlatStyle = FlatStyle.Flat;
            btnStaffsList.ForeColor = Color.Gainsboro;
            btnStaffsList.Location = new Point(0, 0);
            btnStaffsList.Margin = new Padding(4, 3, 4, 3);
            btnStaffsList.Name = "btnStaffsList";
            btnStaffsList.Size = new Size(131, 38);
            btnStaffsList.TabIndex = 0;
            btnStaffsList.Text = "Staffs List";
            btnStaffsList.Click += BtnCategoryList_Click;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.ForeColor = Color.Gainsboro;
            btnSettings.Location = new Point(0, 92);
            btnSettings.Margin = new Padding(4, 3, 4, 3);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(131, 52);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "Settings";
            btnSettings.Click += BtnSettings_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.Gainsboro;
            btnDashboard.Location = new Point(0, 40);
            btnDashboard.Margin = new Padding(4, 30, 4, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(131, 52);
            btnDashboard.TabIndex = 4;
            btnDashboard.Text = "Dashboard";
            // 
            // btnToggleMenu
            // 
            btnToggleMenu.BackColor = Color.FromArgb(51, 51, 76);
            btnToggleMenu.Dock = DockStyle.Top;
            btnToggleMenu.FlatAppearance.BorderSize = 0;
            btnToggleMenu.FlatStyle = FlatStyle.Flat;
            btnToggleMenu.ForeColor = Color.Gainsboro;
            btnToggleMenu.Location = new Point(131, 0);
            btnToggleMenu.Margin = new Padding(4, 3, 4, 3);
            btnToggleMenu.Name = "btnToggleMenu";
            btnToggleMenu.Size = new Size(1094, 52);
            btnToggleMenu.TabIndex = 3;
            btnToggleMenu.UseVisualStyleBackColor = false;
            // 
            // contentWrapper
            // 
            contentWrapper.Dock = DockStyle.Fill;
            contentWrapper.Location = new Point(131, 52);
            contentWrapper.Margin = new Padding(4, 3, 4, 3);
            contentWrapper.Name = "contentWrapper";
            contentWrapper.Size = new Size(1094, 640);
            contentWrapper.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 692);
            Controls.Add(contentWrapper);
            Controls.Add(btnToggleMenu);
            Controls.Add(panelMenu);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            Text = "FormMain";
            panelMenu.ResumeLayout(false);
            panelProductManagementSubmenu.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
