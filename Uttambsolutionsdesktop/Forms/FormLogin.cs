using DBL.Models;
using Uttambsolutionsdesktop.Models;
using Uttambsolutionsdesktop.Views;

namespace Uttambsolutionsdesktop
{
    public partial class FormLogin : Form, ILoginView
    {
        private readonly LoginPresenter _presenter;

        public FormLogin(string connectionString)
        {
            InitializeComponent();
            _presenter = new LoginPresenter(this, connectionString);
        }

        public string UserName => txt_UserName.Text;
        public string Password => txt_Password.Text;

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void OpenMainForm(string UserId, List<string> permissions)
        {
            // Set up the session
            UserSession.StartSession(UserId,UserName, permissions); // Change "User" to the actual user role

            // Open the main form
            this.Hide();
            FormMain fm = new FormMain(UserSession.Userid, UserSession.Username, UserSession.Permissions);
            fm.Show();
        }


        private void btn_Submit_Click(object sender, EventArgs e)
        {
            _presenter.Login();
        }
    }

}