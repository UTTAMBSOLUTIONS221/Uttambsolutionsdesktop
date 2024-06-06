using System;
using System.Collections.Generic;
using Uttambsolutionsdesktop.Forms;
using Uttambsolutionsdesktop.Views;

namespace Uttambsolutionsdesktop.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly string _userId;
        private readonly string _username;
        private readonly List<string> _permissions;

        public MainPresenter(IMainView view, string userId, string username, List<string> permissions)
        {
            _view = view;
            _userId = userId;
            _username = username;
            _permissions = permissions;
            Initialize();
        }

        private void Initialize()
        {
            string greeting = GetGreeting();
            string welcomeMessage = $"{greeting}, {_username}";
            _view.SetWelcomeMessage(welcomeMessage);
        }

        public void HandleSettingsButtonClicked()
        {
            _view.ToggleSettingsSubmenuVisibility();
        }

        public void HandleStaffButtonClicked(Panel contentWrapper)
        {
            // Create an instance of staffPageForm
            SystemStaffForm staffPageForm = new SystemStaffForm(_userId);

            // Set the size of the staffPageForm
            staffPageForm.Size = new Size(contentWrapper.Width, contentWrapper.Height);

            // Set the location of the staffPageForm
            staffPageForm.Location = new Point(0, 0);

            // Clear the contentWrapper panel
            contentWrapper.Controls.Clear();

            // Add the staffPageForm to the contentWrapper panel
            contentWrapper.Controls.Add(staffPageForm);
        }


        public void HandleProductManagementButtonClicked()
        {
            _view.ToggleProductManagementSubmenuVisibility();
        }
        public void HandleBrandListButtonClicked(Panel contentWrapper)
        {
            // Create an instance of ProductPageForm
            ProductBrandForm brandPageForm = new ProductBrandForm(_userId);

            // Set the size of the ProductPageForm
            brandPageForm.Size = new Size(contentWrapper.Width, contentWrapper.Height);

            // Set the location of the ProductPageForm
            brandPageForm.Location = new Point(0, 0);

            // Clear the contentWrapper panel
            contentWrapper.Controls.Clear();

            // Add the ProductPageForm to the contentWrapper panel
            contentWrapper.Controls.Add(brandPageForm);
        }
        public void HandleCategoryListButtonClicked(Panel contentWrapper)
        {
            // Create an instance of CategoryPageForm
            ProductSaleForm productSaleForm = new ProductSaleForm(_userId);

            // Set the size of the CategoryPageForm
            productSaleForm.Size = new Size(contentWrapper.Width, contentWrapper.Height);

            // Set the location of the CategoryPageForm
            productSaleForm.Location = new Point(0, 0);

            // Clear the contentWrapper panel
            contentWrapper.Controls.Clear();

            // Add the CategoryPageForm to the contentWrapper panel
            contentWrapper.Controls.Add(productSaleForm);
        }

        public void HandleProductListButtonClicked(Panel contentWrapper)
        {
            // Create an instance of ProductPageForm
            ProductPageForm productPageForm = new ProductPageForm(_userId);

            // Set the size of the ProductPageForm
            productPageForm.Size = new Size(contentWrapper.Width, contentWrapper.Height);

            // Set the location of the ProductPageForm
            productPageForm.Location = new Point(0, 0);

            // Clear the contentWrapper panel
            contentWrapper.Controls.Clear();

            // Add the ProductPageForm to the contentWrapper panel
            contentWrapper.Controls.Add(productPageForm);
        }

        private string GetGreeting()
        {
            DateTime currentTime = DateTime.Now;
            if (currentTime.Hour < 12)
            {
                return "Good morning";
            }
            else if (currentTime.Hour < 18)
            {
                return "Good afternoon";
            }
            else
            {
                return "Good evening";
            }
        }
    }
}
