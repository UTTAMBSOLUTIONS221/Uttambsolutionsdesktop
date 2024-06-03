using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Uttambsolutionsdesktop.Views;

public partial class FormMain : Form, IMainView
{
    private string _userid;
    private string _username;
    private List<string> _permissions;

    private Panel panelMenu;
    private Button btnToggleMenu;
    private Panel contentWrapper;

    // Menu buttons
    private Button btnDashboard;
    private Button btnSettings;
    private Button btnProductManagement; // Renamed from btnStations
    private Panel panelSettingsSubmenu;
    private Panel panelProductManagementSubmenu; // Renamed from panelStationsSubmenu

    public FormMain(string userid, string username, List<string> permissions)
    {
        InitializeComponent();
        _userid = userid;
        _username = username;
        _permissions = permissions;

        // Set welcome message with username and time of the day
        SetWelcomeMessage();
    }

    private void SetWelcomeMessage()
    {
        // Get the current time
        DateTime currentTime = DateTime.Now;

        // Define the greeting based on the time of the day
        string greeting = "";
        if (currentTime.Hour < 12)
        {
            greeting = "Good morning, ";
        }
        else if (currentTime.Hour < 18)
        {
            greeting = "Good afternoon, ";
        }
        else
        {
            greeting = "Good evening, ";
        }

        // Concatenate the greeting with the username
        string welcomeMessage = greeting + _username;

        // Set the welcome message to the button text
        this.btnToggleMenu.Text = welcomeMessage;
    }

    private void InitializeComponent()
    {
        this.panelMenu = new Panel();
        this.btnToggleMenu = new Button();
        this.contentWrapper = new Panel();

        // Initialize menu buttons
        this.btnDashboard = new Button();
        this.btnSettings = new Button();
        this.btnProductManagement = new Button(); // Renamed from btnStations
        this.panelSettingsSubmenu = new Panel();
        this.panelProductManagementSubmenu = new Panel(); // Renamed from panelStationsSubmenu

        this.SuspendLayout();

        // Form setup
        this.ClientSize = new Size(1050, 600);
        this.Controls.Add(this.contentWrapper);
        this.Controls.Add(this.btnToggleMenu);
        this.Controls.Add(this.panelMenu);
        this.Text = "FormMain";

        // Panel Menu
        this.panelMenu.BackColor = Color.FromArgb(51, 51, 76);
        this.panelMenu.Dock = DockStyle.Left;
        this.panelMenu.Location = new Point(0, 0);
        this.panelMenu.Size = new Size(150, 600);
        this.panelMenu.Controls.Add(this.panelProductManagementSubmenu); // Renamed from panelStationsSubmenu
        this.panelMenu.Controls.Add(this.btnProductManagement); // Renamed from btnStations
        this.panelMenu.Controls.Add(this.panelSettingsSubmenu);
        this.panelMenu.Controls.Add(this.btnSettings);
        this.panelMenu.Controls.Add(this.btnDashboard);

        // Toggle Menu Button
        this.btnToggleMenu.BackColor = Color.FromArgb(51, 51, 76);
        this.btnToggleMenu.Dock = DockStyle.Top;
        this.btnToggleMenu.FlatAppearance.BorderSize = 0;
        this.btnToggleMenu.FlatStyle = FlatStyle.Flat;
        this.btnToggleMenu.ForeColor = Color.Gainsboro;
        this.btnToggleMenu.Location = new Point(150, 0);
        this.btnToggleMenu.Size = new Size(900, 45);

        // Content Wrapper
        this.contentWrapper.Dock = DockStyle.Fill;
        this.contentWrapper.Location = new Point(150, 45);
        this.contentWrapper.Size = new Size(900, 555);

        // Dashboard Button
        this.btnDashboard.Dock = DockStyle.Top;
        this.btnDashboard.FlatAppearance.BorderSize = 0;
        this.btnDashboard.FlatStyle = FlatStyle.Flat;
        this.btnDashboard.ForeColor = Color.Gainsboro;
        this.btnDashboard.Location = new Point(0, 20);
        this.btnDashboard.Size = new Size(150, 45);
        this.btnDashboard.Text = "Dashboard";

        // Settings Button
        this.btnSettings.Dock = DockStyle.Top;
        this.btnSettings.FlatAppearance.BorderSize = 0;
        this.btnSettings.FlatStyle = FlatStyle.Flat;
        this.btnSettings.ForeColor = Color.Gainsboro;
        this.btnSettings.Location = new Point(0, 65);
        this.btnSettings.Size = new Size(150, 45);
        this.btnSettings.Text = "Settings";
        this.btnSettings.Click += new EventHandler(this.BtnSettings_Click);

        // Settings Submenu
        this.panelSettingsSubmenu.BackColor = Color.FromArgb(35, 32, 39);
        this.panelSettingsSubmenu.Dock = DockStyle.Top;
        this.panelSettingsSubmenu.Location = new Point(0, 90);
        this.panelSettingsSubmenu.Size = new Size(150, 90);
        this.panelSettingsSubmenu.Visible = false;

        // Product Management Button 
        this.btnProductManagement.Dock = DockStyle.Top;
        this.btnProductManagement.FlatAppearance.BorderSize = 0;
        this.btnProductManagement.FlatStyle = FlatStyle.Flat;
        this.btnProductManagement.ForeColor = Color.Gainsboro;
        this.btnProductManagement.Location = new Point(0, 110);
        this.btnProductManagement.Size = new Size(150, 45);
        this.btnProductManagement.Text = "Product Management";
        this.btnProductManagement.Click += new EventHandler(this.BtnProductManagement_Click); // Renamed from BtnStations_Click

        // Product Management Submenu 
        this.panelProductManagementSubmenu.BackColor = Color.FromArgb(35, 32, 39);
        this.panelProductManagementSubmenu.Dock = DockStyle.Top;
        this.panelProductManagementSubmenu.Location = new Point(0, 180);
        this.panelProductManagementSubmenu.Size = new Size(150, 135);
        this.panelProductManagementSubmenu.Visible = false;

        // Product List Button (Submenu)
        Button btnProductList = new Button();
        btnProductList.Dock = DockStyle.Bottom; // Change to DockStyle.Bottom
        btnProductList.FlatAppearance.BorderSize = 0;
        btnProductList.FlatStyle = FlatStyle.Flat;
        btnProductList.ForeColor = Color.Gainsboro;
        btnProductList.Size = new Size(150, 45);
        btnProductList.Text = "Product List";
        btnProductList.Click += new EventHandler(this.BtnProductList_Click); // Add event handler for click
        this.panelProductManagementSubmenu.Controls.Add(btnProductList);

        // Category List Button (Submenu)
        Button btnCategoryList = new Button();
        btnCategoryList.Dock = DockStyle.Top; // Change to DockStyle.Top
        btnCategoryList.FlatAppearance.BorderSize = 0;
        btnCategoryList.FlatStyle = FlatStyle.Flat;
        btnCategoryList.ForeColor = Color.Gainsboro;
        btnCategoryList.Size = new Size(150, 45);
        btnCategoryList.Text = "Category List";
        btnCategoryList.Click += new EventHandler(this.BtnCategoryList_Click); // Add event handler for click
        this.panelProductManagementSubmenu.Controls.Add(btnCategoryList);

        this.ResumeLayout(false);
    }

    private void BtnSettings_Click(object sender, EventArgs e)
    {
        ToggleSettingsSubmenuVisibility();
    }

    private void BtnProductManagement_Click(object sender, EventArgs e)
    {
        ToggleProductManagementSubmenuVisibility();
    }

    private void BtnCategoryList_Click(object sender, EventArgs e)
    {
        // Handle Category List button click event
    }

    private void BtnProductList_Click(object sender, EventArgs e)
    {
        // Handle Product List button click event
    }


    public void SetDashboardButtonClickHandler(EventHandler handler)
    {
        btnDashboard.Click += handler;
    }

    public void SetSettingsButtonClickHandler(EventHandler handler)
    {
        btnSettings.Click += handler;
    }

    public void SetProductsButtonClickHandler(EventHandler handler)
    {
        btnProductManagement.Click += handler;
    }

    public void SetToggleMenuButtonClickHandler(EventHandler handler)
    {
        btnToggleMenu.Click += handler;
    }

    public void ToggleSettingsSubmenuVisibility()
    {
        panelSettingsSubmenu.Visible = !panelSettingsSubmenu.Visible;
    }

    public void ToggleProductManagementSubmenuVisibility()
    {
        panelProductManagementSubmenu.Visible = !panelProductManagementSubmenu.Visible;
    }

    public void ToggleMenuVisibility()
    {
        panelMenu.Visible = !panelMenu.Visible;
        if (panelMenu.Visible)
        {
            btnToggleMenu.Dock = DockStyle.Top;
        }
        else
        {
            btnToggleMenu.Dock = DockStyle.Left;
        }
    }
}
