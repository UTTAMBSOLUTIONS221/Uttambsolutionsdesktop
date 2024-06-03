using Uttambsolutionsdesktop.Views;

namespace Uttambsolutionsdesktop.Presenters
{
    // MainPresenter.cs
    public class MainPresenter
    {
        private readonly IMainView view;

        public MainPresenter(IMainView view)
        {
            this.view = view;

            this.view.SetDashboardButtonClickHandler(OnDashboardButtonClick);
            this.view.SetSettingsButtonClickHandler(OnSettingsButtonClick);
            this.view.SetProductsButtonClickHandler(OnProductsButtonClick);
            this.view.SetToggleMenuButtonClickHandler(OnToggleMenuButtonClick);
        }

        private void OnDashboardButtonClick(object sender, EventArgs e)
        {
            // Handle dashboard button click
        }

        private void OnSettingsButtonClick(object sender, EventArgs e)
        {
            view.ToggleSettingsSubmenuVisibility();
        }

        private void OnProductsButtonClick(object sender, EventArgs e)
        {
            view.ToggleProductManagementSubmenuVisibility();
        }

        private void OnToggleMenuButtonClick(object sender, EventArgs e)
        {
            view.ToggleMenuVisibility();
        }
    }

}
