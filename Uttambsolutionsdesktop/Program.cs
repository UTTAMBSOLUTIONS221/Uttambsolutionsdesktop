using System;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace Uttambsolutionsdesktop
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin(config));
        }
    }
}
