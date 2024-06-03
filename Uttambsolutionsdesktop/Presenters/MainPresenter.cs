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
            this.view.SetStationsButtonClickHandler(OnStationsButtonClick);
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

        private void OnStationsButtonClick(object sender, EventArgs e)
        {
            view.ToggleStationsSubmenuVisibility();
        }

        private void OnToggleMenuButtonClick(object sender, EventArgs e)
        {
            view.ToggleMenuVisibility();
        }
    }

}
