using System.Collections.Generic;
using System.Data.SQLite;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            DatabaseManager.ConnectionString = connectionString;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
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
                int superAdminRoleId = -1;
                if (!databaseExists)
                {
                    // Get RoleId of 'Super Admin'
                    string getRoleIdQuery = "SELECT RoleId FROM Roles WHERE RoleName = 'Super Admin'";
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

                // Create the SystemStaffs  table if it doesn't exist
                string createSystemStaffsTableQuery = "CREATE TABLE IF NOT EXISTS SystemStaffs  (" +
                                                               "Userid INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                                               "FirstName TEXT, " +
                                                               "LastName TEXT, " +
                                                               "Phonenumber TEXT, " +
                                                               "Username TEXT, " +
                                                               "Emailaddress TEXT, " +
                                                               "Roleid INTEGER, " +
                                                               "Passharsh TEXT, " +
                                                               "Passwords TEXT, " +
                                                               "Isactive BOOLEAN, " +
                                                               "Isdeleted BOOLEAN, " +
                                                               "Loginstatus INTEGER, " +
                                                               "Passwordresetdate DATETIME, " +
                                                               "Createdby INTEGER, " +
                                                               "Modifiedby INTEGER, " +
                                                               "Lastlogin DATETIME, " +
                                                               "Datemodified DATETIME, " +
                                                               "Datecreated DATETIME)";
                using (SQLiteCommand cmd = new SQLiteCommand(createSystemStaffsTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                // Insert a new user with the specified data if the database was just created
                if (!databaseExists)
                {
                    string insertUserQuery = "INSERT INTO SystemStaffs  (" +
                                             "FirstName, LastName, Phonenumber, Username, Emailaddress, Roleid, Passharsh, Passwords, Isactive, Isdeleted, Loginstatus, Passwordresetdate, Createdby, Modifiedby, Lastlogin, Datemodified, Datecreated) " +
                                             "VALUES (@FirstName, @LastName, @Phonenumber, @Username, @Emailaddress, @Roleid, @Passharsh, @Passwords, @Isactive, @Isdeleted, @Loginstatus, @Passwordresetdate, @Createdby, @Modifiedby, @Lastlogin, @Datemodified, @Datecreated)";

                    using (SQLiteCommand cmd = new SQLiteCommand(insertUserQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", "System");
                        cmd.Parameters.AddWithValue("@LastName", "Admin");
                        cmd.Parameters.AddWithValue("@Phonenumber", DBNull.Value);
                        cmd.Parameters.AddWithValue("@Username", "admin");
                        cmd.Parameters.AddWithValue("@Emailaddress", "franciskingori448@gmail.com");
                        cmd.Parameters.AddWithValue("@Roleid", superAdminRoleId);
                        cmd.Parameters.AddWithValue("@Passharsh", "TKQLEMJWBCTP");
                        cmd.Parameters.AddWithValue("@Passwords", "uB0oMs5jTtZ3fSUZPPu+q4Y3gV4e0xXefo8sKWchKOY=");
                        cmd.Parameters.AddWithValue("@Isactive", true);
                        cmd.Parameters.AddWithValue("@Isdeleted", false);
                        cmd.Parameters.AddWithValue("@Loginstatus", 0);
                        cmd.Parameters.AddWithValue("@Passwordresetdate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Createdby", 0);
                        cmd.Parameters.AddWithValue("@Modifiedby", 0);
                        cmd.Parameters.AddWithValue("@Lastlogin", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Datemodified", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Datecreated", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }
                }
                //Create UnitOfMeasure table
                string createUomTableQuery = "CREATE TABLE IF NOT EXISTS UnitOfMeasure (" +
                                                "Uomid INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                                "UomName TEXT, " +
                                                "UomSymbol TEXT)";
                using (SQLiteCommand cmd = new SQLiteCommand(createUomTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                if (!databaseExists)
                {
                    //Insert data into UnitOfMeasure table
                    string insertUomDataQuery = "INSERT INTO UnitOfMeasure (UomName, UomSymbol) VALUES " +
                                                "('Gram', 'G'), " +
                                                "('Milligram', 'Mg'), " +
                                                "('Kilogram', 'Kg'), " +
                                                "('Litre', 'L'), " +
                                                "('Millilitre', 'Ml')";
                    using (SQLiteCommand cmd = new SQLiteCommand(insertUomDataQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                //Category Table
                string createCategoriesTableQuery = "CREATE TABLE IF NOT EXISTS Categories (" +
                                                       "CategoryId INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                                       "CategoryName TEXT, " +
                                                       "Createdby INTEGER, " +
                                                       "Modifiedby INTEGER, " +
                                                       "DateCreated DATETIME, " +
                                                       "DateModified DATETIME)";
                using (SQLiteCommand cmd = new SQLiteCommand(createCategoriesTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                if (!databaseExists)
                {
                    //Insert into Category Table
                    string insertCategoryDataQuery = "INSERT INTO Categories (CategoryName, Createdby, Modifiedby, DateCreated, DateModified) " +
                                    "VALUES ('Default Category', 1, 1, DATETIME('now'), DATETIME('now'))";
                    using (SQLiteCommand cmd = new SQLiteCommand(insertCategoryDataQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                }
                // Create TaxCategory Table
                string createTaxCategoryTableQuery = "CREATE TABLE IF NOT EXISTS TaxCategory (" +
                                                        "TaxCategoryId INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                                        "TaxCategoryName TEXT, " +
                                                        "Createdby INTEGER, " +
                                                        "Modifiedby INTEGER, " +
                                                        "DateCreated DATETIME, " +
                                                        "DateModified DATETIME)";
                using (SQLiteCommand cmd = new SQLiteCommand(createTaxCategoryTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                if (!databaseExists)
                {
                    // Insert into TaxCategory Table
                    string insertTaxCategoryDataQuery = "INSERT INTO TaxCategory (TaxCategoryName, Createdby, Modifiedby, DateCreated, DateModified) " +
                                                    "VALUES ('Default Tax Category', 1, 1, DATETIME('now'), DATETIME('now'))";
                    using (SQLiteCommand cmd = new SQLiteCommand(insertTaxCategoryDataQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                // Create TaxCategoryValues Table
                string createTaxCategoryValuesTableQuery = "CREATE TABLE IF NOT EXISTS TaxCategoryValues (" +
                                                            "TaxCategoryValueId INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                                            "TaxCategoryId INTEGER, " +
                                                            "TaxValue INTEGER DEFAULT 16, " +
                                                            "Createdby INTEGER, " +
                                                            "Modifiedby INTEGER, " +
                                                            "DateCreated DATETIME, " +
                                                            "DateModified DATETIME, " +
                                                            "FOREIGN KEY (TaxCategoryId) REFERENCES TaxCategory(TaxCategoryId))";
                using (SQLiteCommand cmd = new SQLiteCommand(createTaxCategoryValuesTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                if (!databaseExists)
                {
                    // Insert Default Value into TaxCategoryValues Table
                    string insertDefaultTaxCategoryValueQuery = "INSERT INTO TaxCategoryValues (TaxCategoryId, TaxValue, Createdby, Modifiedby, DateCreated, DateModified) " +
                                                             "SELECT TaxCategoryId, 16, 1, 1, DATETIME('now'), DATETIME('now') FROM TaxCategory";
                    using (SQLiteCommand cmd = new SQLiteCommand(insertDefaultTaxCategoryValueQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                // Create Product table
                string createProductTableQuery = "CREATE TABLE IF NOT EXISTS Product (" +
                                                  "ProductId INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                                  "ProductName TEXT, " +
                                                  "UomId INTEGER, " +
                                                  "CategoryId INTEGER, " +
                                                  "TaxCategoryId INTEGER, " +
                                                  "Barcode TEXT, " +
                                                  "Units REAL, " +
                                                  "Price REAL, " +
                                                  "Createdby INTEGER, " +
                                                  "Modifiedby INTEGER, " +
                                                  "Datecreated DATETIME, " +
                                                  "Datemodified DATETIME, " +
                                                  "FOREIGN KEY (UomId) REFERENCES UnitOfMeasure(UomId), " +
                                                  "FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId), " +
                                                  "FOREIGN KEY (TaxCategoryId) REFERENCES TaxCategory(TaxCategoryId))";
                using (SQLiteCommand cmd = new SQLiteCommand(createProductTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }






            }
        }


        public static class DatabaseManager
        {
            private static string connectionString;

            public static string ConnectionString
            {
                get { return connectionString; }
                set { connectionString = value; }
            }

            private static SQLiteConnection connection;

            public static SQLiteConnection Connection
            {
                get
                {
                    if (connection == null)
                    {
                        connection = new SQLiteConnection(connectionString);
                        connection.Open();
                    }
                    else if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    return connection;
                }
            }
        }

    }
}
