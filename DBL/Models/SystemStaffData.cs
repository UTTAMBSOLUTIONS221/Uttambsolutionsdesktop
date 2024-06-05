using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Models
{
    public class SystemStaffData
    {
        public int Userid { get; set; }
        public string? FullName { get; set; }
        public string? Phonenumber { get; set; }
        public string? Username { get; set; }
        public string? Emailaddress { get; set; }
        public int Roleid { get; set; }
        public string? Passharsh { get; set; }
        public string? Passwords { get; set; }
        public bool Isactive { get; set; }
        public bool Isdeleted { get; set; }
        public int Loginstatus { get; set; }
        public DateTime? Passwordresetdate { get; set; }
        public int Createdby { get; set; }
        public int Modifiedby { get; set; }
        public DateTime? Lastlogin { get; set; }
        public DateTime? Datemodified { get; set; }
        public DateTime? Datecreated { get; set; }
    }
}
