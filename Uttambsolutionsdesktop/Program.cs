using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Uttambsolutionsdesktop
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            string databasePath = Path.Combine(Application.StartupPath, "Uttambsolutioninv.db");
            string connectionString = $"Data Source={databasePath};Version=3;";

            // Ensure the database exists
            CreateDatabaseIfNotExists(databasePath, connectionString);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin(connectionString));
        }

        static void CreateDatabaseIfNotExists(string databasePath, string connectionString)
        {
            if (!File.Exists(databasePath))
            {
                SQLiteConnection.CreateFile(databasePath);

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string createTableQuery = "CREATE TABLE IF NOT EXISTS SampleTable (ID INTEGER PRIMARY KEY, Name TEXT)";
                    using (SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
