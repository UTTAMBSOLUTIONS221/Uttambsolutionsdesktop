using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uttambsolutionsdesktop.Models
{
    public static class UserSession
    {
        public static string? Userid { get; private set; }
        public static string? Username { get; private set; }
        public static string? UserRole { get; private set; }
        public static List<string>? Permissions { get; private set; }
        public static bool IsLoggedIn { get; private set; } = false;

        public static void StartSession(string userid, string username, List<string> permissions)
        {
            Userid = userid;
            Username = username;
            Permissions = permissions;
            IsLoggedIn = true;
        }

        public static void EndSession()
        {
            Username = string.Empty;
            UserRole = string.Empty;
            Permissions = null;
            IsLoggedIn = false;
        }
    }

}
