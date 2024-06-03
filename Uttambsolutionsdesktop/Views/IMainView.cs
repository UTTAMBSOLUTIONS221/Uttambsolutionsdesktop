namespace Uttambsolutionsdesktop.Views
{
    public interface IMainView
    {
        void SetDashboardButtonClickHandler(EventHandler handler);
        void SetSettingsButtonClickHandler(EventHandler handler);
        void SetProductsButtonClickHandler(EventHandler handler);
        void SetToggleMenuButtonClickHandler(EventHandler handler);
        void SetWelcomeMessage(string message);

        void ToggleSettingsSubmenuVisibility();
        void ToggleProductManagementSubmenuVisibility();
        void ToggleMenuVisibility();
    }

}
