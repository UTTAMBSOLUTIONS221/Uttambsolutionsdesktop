using DBL;
using Microsoft.Extensions.Configuration;
using Uttambsolutionsdesktop.Utils;
using Uttambsolutionsdesktop.Views;

namespace Uttambsolutionsdesktop
{
    public partial class FormLogin : Form
    {
        private readonly BL bl;
        private readonly IConfiguration _config;

        public FormLogin(IConfiguration config)
        {
            InitializeComponent();
            _config = config;
            bl = new BL(Util.ShareConnectionString(_config));
        }

        private async void btn_Submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_UserName.Text) || string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }

            var resp = await bl.AuthorizeUser(txt_UserName.Text, txt_Password.Text);
            if (resp.RespStatus == 0)
            {
                MessageBox.Show("Login Successful!");
                this.Hide();
                FormMain fm = new FormMain();
                fm.Show();
            }
            else if (resp.RespStatus == 1)
            {
                MessageBox.Show(resp.RespMessage);
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }
        }
    }
}