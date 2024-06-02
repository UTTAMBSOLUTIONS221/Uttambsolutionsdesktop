﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Models
{

    public class UsermodelResponce
    {
        public int RespStatus { get; set; }
        public string? RespMessage { get; set; }
        public string? Token { get; set; }
        public UsermodeldataResponce? Usermodel { get; set; }
    }
    public class UsermodeldataResponce
    {
        public long Userid { get; set; }
        public string? Fullname { get; set; }
        public string? Phonenumber { get; set; }
        public string? Username { get; set; }
        public string? Emailaddress { get; set; }
        public int Roleid { get; set; }
        public string? Rolename { get; set; }
        public string? Passharsh { get; set; }
        public string? Passwords { get; set; }
        public bool Isactive { get; set; }
        public bool Isdeleted { get; set; }
        public int Loginstatus { get; set; }
        public DateTime Passwordresetdate { get; set; }
        public long Createdby { get; set; }
        public long Modifiedby { get; set; }
        public DateTime Lastlogin { get; set; }
        public DateTime Datemodified { get; set; }
        public DateTime Datecreated { get; set; }
    }
}
