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

        public void OpenMainForm()
        {
            this.Hide();
            FormMain fm = new FormMain();
            fm.Show();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            _presenter.Login();
        }
    }

}