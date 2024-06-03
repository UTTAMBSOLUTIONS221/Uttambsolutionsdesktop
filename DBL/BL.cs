﻿using DBL.Entities;
using DBL.Helpers;
using DBL.Models;
using DBL.UOW;

namespace DBL
{
    public class BL
    {
        private UnitOfWork db;
        private string _connString;
        static bool mailSent = false;
        Encryptdecrypt sec = new Encryptdecrypt();
        Stringgenerator str = new Stringgenerator();
        public BL(string connString)
        {
            this._connString = connString;
            db = new UnitOfWork(connString);
        }

        #region Authorize User
        public Task<UsermodelResponce> AuthorizeUser(string userName, string password)
        {
            return Task.Run(async () =>
            {
                UsermodelResponce userModel = new UsermodelResponce { };
                var resp = db.SecurityRepository.VerifySystemStaff(userName);
                if (resp.RespStatus == 0)
                {
                    Encryptdecrypt sec = new Encryptdecrypt();
                    string descpass = sec.Decrypt(resp.Usermodel.Passwords, resp.Usermodel.Passharsh);
                    if (password == descpass)
                    {
                        userModel = new UsermodelResponce
                        {
                            RespStatus = resp.RespStatus,
                            RespMessage = resp.RespMessage,
                            Usermodel = new UsermodeldataResponce
                            {
                                Userid = resp.Usermodel.Userid,
                                Fullname = resp.Usermodel.Fullname,
                                Phonenumber = resp.Usermodel.Phonenumber,
                                Username = resp.Usermodel.Username,
                                Emailaddress = resp.Usermodel.Emailaddress,
                                Roleid = resp.Usermodel.Roleid,
                                Rolename = resp.Usermodel.Rolename,
                                Passharsh = resp.Usermodel.Passharsh,
                                Passwords = resp.Usermodel.Passwords,
                                Isactive = resp.Usermodel.Isactive,
                                Isdeleted = resp.Usermodel.Isdeleted,
                                //Loginstatus = Enum.GetName(typeof(UserLoginStatus), Convert.ToInt32(resp.Usermodel.Loginstatus)),
                                Loginstatus = resp.Usermodel.Loginstatus,
                                Passwordresetdate = resp.Usermodel.Passwordresetdate,
                                Createdby = resp.Usermodel.Createdby,
                                Modifiedby = resp.Usermodel.Modifiedby,
                                Lastlogin = resp.Usermodel.Lastlogin,
                                Datemodified = resp.Usermodel.Datemodified,
                                Datecreated = resp.Usermodel.Datecreated,
                            }
                        };
                        return userModel;
                    }
                    else
                    {
                        userModel.RespStatus = 1;
                        userModel.RespMessage = "Incorrect Username or Password";
                    }
                }
                else
                {
                    userModel.RespStatus = 1;
                    userModel.RespMessage = resp.RespMessage;
                }
                return userModel;
            });
        }
        #endregion

        #region User Role Permissions
        public Task<IEnumerable<string>> GetPermissionsForUser(long RoleId)
        {
            return Task.Run(() =>
            {
                var Resp = db.SecurityRepository.GetPermissionsForUser(RoleId);
                return Resp;
            });
        }
        #endregion

        #region Producct Categories
        public Task<IEnumerable<Category>> GetAllCategories()
        {
            return Task.Run(() =>
            {
                var Resp = db.CategoryRepository.GetAllCategories();
                return Resp;
            });
        }
        public Task<IEnumerable<Category>> GetCategoriesByValue(string SearchValue)
        {
            return Task.Run(() =>
            {
                var Resp = db.CategoryRepository.GetAllCategories();
                return Resp;
            });
        }
        #endregion
    }
}
