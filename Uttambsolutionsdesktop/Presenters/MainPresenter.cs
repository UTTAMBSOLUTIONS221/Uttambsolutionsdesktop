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

        public void HandleProductManagementButtonClicked()
        {
            _view.ToggleProductManagementSubmenuVisibility();
        }
        public void HandleCategoryListButtonClicked(Panel contentWrapper)
        {
            // Create an instance of CategoryPageForm
            CategoryPageForm categoryPageForm = new CategoryPageForm();

            // Set the size of the CategoryPageForm
            categoryPageForm.Size = new Size(contentWrapper.Width, contentWrapper.Height);

            // Set the location of the CategoryPageForm
            categoryPageForm.Location = new Point(0, 0);

            // Clear the contentWrapper panel
            contentWrapper.Controls.Clear();

            // Add the CategoryPageForm to the contentWrapper panel
            contentWrapper.Controls.Add(categoryPageForm);
        }

        public void HandleProductListButtonClicked()
        {
            // Handle product list button click event
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
