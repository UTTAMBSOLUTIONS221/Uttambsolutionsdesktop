using DBL.Models;
using System;
using System.Windows.Forms;

namespace Uttambsolutionsdesktop.Views
{
    partial class FormMain : Form, IMainView
    {
        private Panel sidePanel;
        private Button btnHome;
        private Button btnSettings;
        private Label lblUserName;
        private Label lblUserRole;
        private UsermodeldataResponce _currentUser;

        public event EventHandler HomeButtonClicked;
        public event EventHandler SettingsButtonClicked;

        public FormMain(UsermodeldataResponce currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            InitializeSideMenu();
        }

        private void InitializeComponent()
        {
            // Initialize form components
            this.sidePanel = new Panel();
            this.btnHome = new Button();
            this.btnSettings = new Button();
            this.lblUserName = new Label();
            this.lblUserRole = new Label();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.sidePanel.Dock = DockStyle.Left;
            this.sidePanel.Width = 200;
            this.sidePanel.Controls.Add(this.lblUserName);
            this.sidePanel.Controls.Add(this.lblUserRole);
            this.sidePanel.Controls.Add(this.btnHome);
            this.sidePanel.Controls.Add(this.btnSettings);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(30, 50);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(140, 40);
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(30, 110);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(140, 40);
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(30, 200);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(100, 20);
            this.lblUserName.Text = _currentUser.Username; // Assign current user's username
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.ForeColor = System.Drawing.Color.White;
            this.lblUserRole.Location = new System.Drawing.Point(30, 240);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(100, 20);
            this.lblUserRole.Text = _currentUser.Rolename; // Assign current user's role name
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sidePanel);
            this.Name = "FormMain";
            this.Text = "Main Form";
            this.ResumeLayout(false);
        }

        private void InitializeSideMenu()
        {
            // You can further customize the side menu layout and content here
        }

        // Event handlers for button clicks
        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeButtonClicked?.Invoke(sender, e);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsButtonClicked?.Invoke(sender, e);
        }
    }
}
