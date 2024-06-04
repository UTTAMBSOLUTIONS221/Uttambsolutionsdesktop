using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Uttambsolutionsdesktop.Presenters;
using Uttambsolutionsdesktop.Views;

namespace Uttambsolutionsdesktop.Forms
{
    public partial class FormMain : Form, IMainView
    {
        private readonly MainPresenter _presenter;

        public FormMain(string userId, string username, List<string> permissions)
        {
            InitializeComponent();
            _presenter = new MainPresenter(this, userId, username, permissions);
        }

        public void SetWelcomeMessage(string message)
        {
            btnToggleMenu.Text = message;
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

        // Event handlers for other buttons can be added similarly

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            _presenter.HandleSettingsButtonClicked();
        }

        private void BtnProductManagement_Click(object sender, EventArgs e)
        {
            _presenter.HandleProductManagementButtonClicked();
        }

        private void BtnCategoryList_Click(object sender, EventArgs e)
        {
            _presenter.HandleCategoryListButtonClicked(contentWrapper);
        }

        private void BtnProductList_Click(object sender, EventArgs e)
        {
            _presenter.HandleProductListButtonClicked(contentWrapper);
        }
    }
}
