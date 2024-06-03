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
        private System.Windows.Forms.Button btnProductManagement;
        private System.Windows.Forms.Panel panelSettingsSubmenu;
        private System.Windows.Forms.Panel panelProductManagementSubmenu;
        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.Button btnCategoryList;

        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelProductManagementSubmenu = new System.Windows.Forms.Panel();
            this.btnCategoryList = new System.Windows.Forms.Button();
            this.btnProductList = new System.Windows.Forms.Button();
            this.btnProductManagement = new System.Windows.Forms.Button();
            this.panelSettingsSubmenu = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnToggleMenu = new System.Windows.Forms.Button();
            this.contentWrapper = new System.Windows.Forms.Panel();
            this.contentWrapper.Location = new System.Drawing.Point(200, 0);
            this.contentWrapper.Size = new System.Drawing.Size(this.ClientSize.Width - 200, this.ClientSize.Height);
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.panelProductManagementSubmenu);
            this.panelMenu.Controls.Add(this.btnProductManagement);
            this.panelMenu.Controls.Add(this.panelSettingsSubmenu);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Size = new System.Drawing.Size(200, this.ClientSize.Height);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.TabIndex = 0;
            // 
            // panelProductManagementSubmenu
            // 
            this.panelProductManagementSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelProductManagementSubmenu.Controls.Add(this.btnCategoryList);
            this.panelProductManagementSubmenu.Controls.Add(this.btnProductList);
            this.panelProductManagementSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductManagementSubmenu.Location = new System.Drawing.Point(0, 220);
            this.panelProductManagementSubmenu.Name = "panelProductManagementSubmenu";
            this.panelProductManagementSubmenu.Size = new System.Drawing.Size(150, 90);
            this.panelProductManagementSubmenu.Visible = false;
            // 
            // btnCategoryList
            // 
            this.btnCategoryList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoryList.FlatAppearance.BorderSize = 0;
            this.btnCategoryList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryList.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCategoryList.Location = new System.Drawing.Point(0, 45);
            this.btnCategoryList.Name = "btnCategoryList";
            this.btnCategoryList.Size = new System.Drawing.Size(150, 45);
            this.btnCategoryList.Text = "Category List";
            this.btnCategoryList.Click += new System.EventHandler(this.BtnCategoryList_Click);
            // 
            // btnProductList
            // 
            this.btnProductList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductList.FlatAppearance.BorderSize = 0;
            this.btnProductList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductList.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProductList.Location = new System.Drawing.Point(0, 0);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(150, 45);
            this.btnProductList.Text = "Product List";
            this.btnProductList.Click += new System.EventHandler(this.BtnProductList_Click);
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductManagement.FlatAppearance.BorderSize = 0;
            this.btnProductManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProductManagement.Location = new System.Drawing.Point(0, 175);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(150, 45);
            this.btnProductManagement.Text = "Product Management";
            this.btnProductManagement.Click += new System.EventHandler(this.BtnProductManagement_Click);
            // 
            // panelSettingsSubmenu
            // 
            this.panelSettingsSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSettingsSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSettingsSubmenu.Location = new System.Drawing.Point(0, 90);
            this.panelSettingsSubmenu.Name = "panelSettingsSubmenu";
            this.panelSettingsSubmenu.Size = new System.Drawing.Size(150, 85);
            this.panelSettingsSubmenu.Visible = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.Location = new System.Drawing.Point(0, 45);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(150, 45);
            this.btnSettings.Text = "Settings";
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(150, 45);
            this.btnDashboard.Text = "Dashboard";
            // 
            // btnToggleMenu
            // 
            this.btnToggleMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnToggleMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnToggleMenu.FlatAppearance.BorderSize = 0;
            this.btnToggleMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnToggleMenu.Location = new System.Drawing.Point(150, 0);
            this.btnToggleMenu.Name = "btnToggleMenu";
            this.btnToggleMenu.Size = new System.Drawing.Size(900, 45);
            // 
            // contentWrapper
            // 
            this.contentWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentWrapper.Location = new System.Drawing.Point(150, 45);
            this.contentWrapper.Name = "contentWrapper";
            this.contentWrapper.Size = new System.Drawing.Size(900, 555);
            this.contentWrapper.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.contentWrapper);
            this.Controls.Add(this.btnToggleMenu);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
