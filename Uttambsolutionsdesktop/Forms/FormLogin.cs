using DBL.Models;
using Uttambsolutionsdesktop.Forms;
using Uttambsolutionsdesktop.Models;
using Uttambsolutionsdesktop.Views;
using static Uttambsolutionsdesktop.Program;

namespace Uttambsolutionsdesktop
{
    public partial class FormLogin : Form, ILoginView
    {
        private readonly LoginPresenter _presenter;

        public FormLogin()
        {
            InitializeComponent();
            _presenter = new LoginPresenter(this, DatabaseManager.ConnectionString);
        }

        public string UserName => txt_UserName.Text;
        public string Password => txt_Password.Text;

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void OpenMainForm(string UserId, string UserName, List<string> permissions)
        {
            // Set up the session
            UserSession.StartSession(UserId,UserName, permissions); // Change "User" to the actual user role

            // Open the main form
            this.Hide();
            FormMain fm = new FormMain(UserSession.Userid, UserSession.Username, UserSession.Permissions);
            //FormHome fm = new FormHome();
            fm.Show();
        }


        private void btn_Submit_Click(object sender, EventArgs e)
        {
            _presenter.Login();
        }
    }

}