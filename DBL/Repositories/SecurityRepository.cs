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
    }
}