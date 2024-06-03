namespace Uttambsolutionsdesktop.Views
{
    public interface IMainView
    {
        void SetDashboardButtonClickHandler(EventHandler handler);
        void SetSettingsButtonClickHandler(EventHandler handler);
        void SetStationsButtonClickHandler(EventHandler handler);
        void SetToggleMenuButtonClickHandler(EventHandler handler);

        void ToggleSettingsSubmenuVisibility();
        void ToggleStationsSubmenuVisibility();
        void ToggleMenuVisibility();
    }

}
