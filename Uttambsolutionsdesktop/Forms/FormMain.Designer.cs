using System;
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
    private Button btnStations;
    private Panel panelSettingsSubmenu;
    private Panel panelStationsSubmenu;

    public FormMain(string userid, string username, List<string> permissions)
    {
        InitializeComponent();
        _userid = userid;
        _username = username;
        _permissions = permissions;

        // You can now use _permissions list to check user permissions
    }

    private void InitializeComponent()
    {
        this.panelMenu = new Panel();
        this.btnToggleMenu = new Button();
        this.contentWrapper = new Panel();

        // Initialize menu buttons
        this.btnDashboard = new Button();
        this.btnSettings = new Button();
        this.btnStations = new Button();
        this.panelSettingsSubmenu = new Panel();
        this.panelStationsSubmenu = new Panel();

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
        this.panelMenu.Controls.Add(this.panelStationsSubmenu);
        this.panelMenu.Controls.Add(this.btnStations);
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
        this.btnToggleMenu.Text = "Uttam Menu";

        // Content Wrapper
        this.contentWrapper.Dock = DockStyle.Fill;
        this.contentWrapper.Location = new Point(150, 45);
        this.contentWrapper.Size = new Size(900, 555);

        // Dashboard Button
        this.btnDashboard.Dock = DockStyle.Top;
        this.btnDashboard.FlatAppearance.BorderSize = 0;
        this.btnDashboard.FlatStyle = FlatStyle.Flat;
        this.btnDashboard.ForeColor = Color.Gainsboro;
        this.btnDashboard.Location = new Point(0, 0);
        this.btnDashboard.Size = new Size(150, 45);
        this.btnDashboard.Text = "Dashboard";

        // Settings Button
        this.btnSettings.Dock = DockStyle.Top;
        this.btnSettings.FlatAppearance.BorderSize = 0;
        this.btnSettings.FlatStyle = FlatStyle.Flat;
        this.btnSettings.ForeColor = Color.Gainsboro;
        this.btnSettings.Location = new Point(0, 45);
        this.btnSettings.Size = new Size(150, 45);
        this.btnSettings.Text = "Settings";
        this.btnSettings.Click += new EventHandler(this.BtnSettings_Click);

        // Settings Submenu
        this.panelSettingsSubmenu.BackColor = Color.FromArgb(35, 32, 39);
        this.panelSettingsSubmenu.Dock = DockStyle.Top;
        this.panelSettingsSubmenu.Location = new Point(0, 90);
        this.panelSettingsSubmenu.Size = new Size(150, 90);
        this.panelSettingsSubmenu.Visible = false;
        // Add submenu buttons to panelSettingsSubmenu here...

        // Stations Button
        this.btnStations.Dock = DockStyle.Top;
        this.btnStations.FlatAppearance.BorderSize = 0;
        this.btnStations.FlatStyle = FlatStyle.Flat;
        this.btnStations.ForeColor = Color.Gainsboro;
        this.btnStations.Location = new Point(0, 135);
        this.btnStations.Size = new Size(150, 45);
        this.btnStations.Text = "Stations";
        this.btnStations.Click += new EventHandler(this.BtnStations_Click);

        // Stations Submenu
        this.panelStationsSubmenu.BackColor = Color.FromArgb(35, 32, 39);
        this.panelStationsSubmenu.Dock = DockStyle.Top;
        this.panelStationsSubmenu.Location = new Point(0, 180);
        this.panelStationsSubmenu.Size = new Size(150, 90);
        this.panelStationsSubmenu.Visible = false;
        // Add submenu buttons to panelStationsSubmenu here...

        this.ResumeLayout(false);
    }

    private void BtnSettings_Click(object sender, EventArgs e)
    {
        ToggleSettingsSubmenuVisibility();
    }

    private void BtnStations_Click(object sender, EventArgs e)
    {
        ToggleStationsSubmenuVisibility();
    }

    public void SetDashboardButtonClickHandler(EventHandler handler)
    {
        btnDashboard.Click += handler;
    }

    public void SetSettingsButtonClickHandler(EventHandler handler)
    {
        btnSettings.Click += handler;
    }

    public void SetStationsButtonClickHandler(EventHandler handler)
    {
        btnStations.Click += handler;
    }

    public void SetToggleMenuButtonClickHandler(EventHandler handler)
    {
        btnToggleMenu.Click += handler;
    }

    public void ToggleSettingsSubmenuVisibility()
    {
        panelSettingsSubmenu.Visible = !panelSettingsSubmenu.Visible;
    }

    public void ToggleStationsSubmenuVisibility()
    {
        panelStationsSubmenu.Visible = !panelStationsSubmenu.Visible;
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
