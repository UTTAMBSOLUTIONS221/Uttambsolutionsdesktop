using Dapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Data.SQLite;
using DBL.Models;

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


    }
}