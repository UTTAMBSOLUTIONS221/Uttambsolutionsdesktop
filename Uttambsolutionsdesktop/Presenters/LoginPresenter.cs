using DBL;
using Uttambsolutionsdesktop.Views;

public class LoginPresenter
{
    private readonly ILoginView _view;
    private readonly BL _bl;

    public LoginPresenter(ILoginView view, string connectionString)
    {
        _view = view;
        _bl = new BL(connectionString);
    }

    public async void Login()
    {
        if (string.IsNullOrWhiteSpace(_view.UserName) || string.IsNullOrWhiteSpace(_view.Password))
        {
            _view.ShowMessage("Please provide Username and Password");
            return;
        }

        var resp = await _bl.AuthorizeUser(_view.UserName, _view.Password);
        if (resp.RespStatus == 0)
        {
            _view.ShowMessage("Login Successful!");
            _view.OpenMainForm();
        }
        else if (resp.RespStatus == 1)
        {
            _view.ShowMessage(resp.RespMessage);
        }
        else
        {
            _view.ShowMessage("Login Failed!");
        }
    }
}
