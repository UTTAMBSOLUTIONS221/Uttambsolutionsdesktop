namespace Uttambsolutionsdesktop.Views
{
    public interface ILoginView
    {
        string UserName { get; }
        string Password { get; }
        void ShowMessage(string message);
        void OpenMainForm();
    }
}
