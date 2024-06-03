using System.Data.SQLite;

namespace Uttambsolutionsdesktop
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            string databasePath = Path.Combine(Application.StartupPath, "Uttambsolutionspos.db");
            string connectionString = $"Data Source={databasePath};Version=3;";

            // Ensure the database exists
            CreateDatabaseIfNotExists(databasePath, connectionString);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin(connectionString));
        }

        static void CreateDatabaseIfNotExists(string databasePath, string connectionString)
        {
            bool databaseExists = File.Exists(databasePath);

            if (!databaseExists)
            {
                SQLiteConnection.CreateFile(databasePath);
            }

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Create the Permission table if it doesn't exist
                string createPermissionTableQuery = "CREATE TABLE IF NOT EXISTS Permission (" +
                                                    "PermissionId INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                                    "Permission VARCHAR(200))";
                using (SQLiteCommand cmd = new SQLiteCommand(createPermissionTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                // Insert permissions data only if the database was just created
                if (!databaseExists)
                {
                    string insertPermissionDataQuery = "INSERT INTO Permission (Permission) VALUES " +
                                                       "('Can_Add_Staff_Role'), " +
                                                       "('Can_Add_Staff'), " +
                                                       "('Can_Add_Product_Category'), " +
                                                       "('Can_Add_Product_Tax'), " +
                                                       "('Can_Add_Product')";
                    using (SQLiteCommand cmd = new SQLiteCommand(insertPermissionDataQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                // Create the Roles table if it doesn't exist
                string createRolesTableQuery = "CREATE TABLE IF NOT EXISTS Roles (" +
                                               "RoleId INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                               "RoleName VARCHAR(200))";
                using (SQLiteCommand cmd = new SQLiteCommand(createRolesTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                // Insert 'Super Admin' role into Roles table if the database was just created
                if (!databaseExists)
                {
                    string insertRoleDataQuery = "INSERT INTO Roles (RoleName) VALUES ('Super Admin')";
                    using (SQLiteCommand cmd = new SQLiteCommand(insertRoleDataQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                // Create the LnkPermRole table if it doesn't exist
                string createLnkPermRoleTableQuery = "CREATE TABLE IF NOT EXISTS LnkPermRole (" +
                                                     "PermissionId INTEGER, " +
                                                     "RoleId INTEGER, " +
                                                     "FOREIGN KEY(PermissionId) REFERENCES Permission(PermissionId), " +
                                                     "FOREIGN KEY(RoleId) REFERENCES Roles(RoleId))";
                using (SQLiteCommand cmd = new SQLiteCommand(createLnkPermRoleTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                // Link all permissions to the 'Super Admin' role if the database was just created
                if (!databaseExists)
                {
                    // Get RoleId of 'Super Admin'
                    string getRoleIdQuery = "SELECT RoleId FROM Roles WHERE RoleName = 'Super Admin'";
                    int superAdminRoleId;
                    using (SQLiteCommand cmd = new SQLiteCommand(getRoleIdQuery, conn))
                    {
                        superAdminRoleId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Get all PermissionIds
                    string getPermissionIdsQuery = "SELECT PermissionId FROM Permission";
                    using (SQLiteCommand cmd = new SQLiteCommand(getPermissionIdsQuery, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int permissionId = reader.GetInt32(0);
                                string insertLnkPermRoleQuery = "INSERT INTO LnkPermRole (PermissionId, RoleId) VALUES (@PermissionId, @RoleId)";
                                using (SQLiteCommand insertCmd = new SQLiteCommand(insertLnkPermRoleQuery, conn))
                                {
                                    insertCmd.Parameters.AddWithValue("@PermissionId", permissionId);
                                    insertCmd.Parameters.AddWithValue("@RoleId", superAdminRoleId);
                                    insertCmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
