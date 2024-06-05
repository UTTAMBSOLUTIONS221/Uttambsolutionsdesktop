using Dapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Data.SQLite;
using DBL.Models;
using DBL.Entities;

namespace DBL.Repositories
{
    public class SecurityRepository : BaseRepository, ISecurityRepository
    {
        public SecurityRepository(string connectionString) : base(connectionString)
        {
        }

        public UsermodelResponce VerifySystemStaff(string Username)
        {
            using (var connection = new SQLiteConnection(_connString))
            {
                connection.Open();
                UsermodelResponce resp = new UsermodelResponce();

                // Execute the query to get user details
                var queryResult = connection.QueryFirstOrDefault<UsermodeldataResponce>(
                    @"SELECT 
                        Userid,
                        FirstName || ' ' || LastName AS Fullname,
                        Phonenumber,
                        Username,
                        Emailaddress,
                        Roleid,
                        Passharsh,
                        Passwords,
                        Isactive,
                        Isdeleted,
                        Loginstatus,
                        Passwordresetdate,
                        Createdby,
                        Modifiedby,
                        Lastlogin,
                        Datemodified,
                        Datecreated
                    FROM 
                        SystemStaffs 
                    WHERE 
                        Username = @Username", new { Username });

                // Check if user exists
                if (queryResult != null)
                {
                    resp.RespStatus = 0;
                    resp.RespMessage = "Login success";
                    resp.Usermodel = queryResult;
                }
                else
                {
                    resp.RespStatus = 1;
                    resp.RespMessage = "Invalid username or User does not Exist!";
                    resp.Usermodel = null;
                }

                return resp;
            }
        }
        public IEnumerable<string> GetPermissionsForUser(long RoleId)
        {
            using (var connection = new SQLiteConnection(_connString))
            {
                connection.Open();
                IEnumerable<string> resp = Enumerable.Empty<string>();

                // Execute the query to fetch permissions
                var permissionsQueryResult = connection.Query<string>(
                    @"SELECT Permission
              FROM Permission
              WHERE PermissionId IN (
                  SELECT PermissionId
                  FROM LnkPermRole
                  WHERE RoleId = @RoleId)", new { RoleId });

                // Check if permissions are found
                if (permissionsQueryResult != null && permissionsQueryResult.Any())
                {
                    resp = permissionsQueryResult.ToList();
                }
                else
                {
                    // If no permissions found, you might want to return null or an empty list
                    // For simplicity, returning an empty list here
                    resp = Enumerable.Empty<string>();
                }

                return resp;
            }
        }

        public IEnumerable<SystemStaffData> GetAllSystemStaffs()
        {
            using (var connection = new SQLiteConnection(_connString))
            {
                connection.Open();

                // Execute the query to fetch all system staff records
                var systemStaffsQueryResult = connection.Query<SystemStaffData>(
                    @"SELECT Userid,  FirstName || ' ' || LastName AS FullName, Phonenumber, Username,Emailaddress, Roleid,Passharsh, Passwords, Isactive , Isdeleted, Loginstatus, Passwordresetdate, Createdby, Modifiedby, Lastlogin, Datemodified, Datecreated FROM SystemStaffs");

                // Return the result
                return systemStaffsQueryResult;
            }
        }

        public Genericmodel SaveStaff(SystemStaff entity)
        {
            using (var connection = new SQLiteConnection(_connString))
            {
                connection.Open();

                if (entity.Userid > 0)
                {
                    // Update the category
                    var result = connection.Execute(
                        @"UPDATE Categories 
                  SET CategoryName = @CategoryName, Modifiedby = @Modifiedby, 
                      DateModified = @DateModified 
                  WHERE CategoryId = @CategoryId",
                        new
                        {
                            entity.Modifiedby,
                            entity.DateModified,
                            entity.CategoryName,
                            entity.CategoryId
                        });

                    // Return appropriate response
                    return result < 1
                        ? new Genericmodel { RespStatus = 2, RespMessage = "Database Error Occurred" }
                        : new Genericmodel { RespStatus = 0, RespMessage = "Category Updated Successfully" };
                }
                else
                {

                    // Check if the category already exists
                    var categoryExists = connection.ExecuteScalar<bool>(
                        "SELECT COUNT(1) FROM Categories WHERE CategoryName = @CategoryName",
                        new { Username = entity.Username });

                    if (categoryExists)
                    {
                        // Category already exists, return 0 (failure)
                        return new Genericmodel { RespStatus = 1, RespMessage = "Category Exists" };
                    }

                    // Insert the category into the database
                    var result = connection.Execute(
                        @"INSERT INTO Categories (CategoryName, Createdby, Modifiedby, DateCreated, DateModified) 
                  VALUES (@CategoryName, @Createdby, @Modifiedby, @DateCreated, @DateModified)",
                        new
                        {
                            entity.CategoryName,
                            entity.Createdby,
                            entity.Modifiedby,
                            entity.DateCreated,
                            entity.DateModified
                        });

                    // Return appropriate response
                    return result < 1
                        ? new Genericmodel { RespStatus = 2, RespMessage = "Database Error Occurred" }
                        : new Genericmodel { RespStatus = 0, RespMessage = "Category Added Successfully" };
                }
            }
        }
    }
}