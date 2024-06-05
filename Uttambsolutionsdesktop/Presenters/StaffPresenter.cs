using DBL.Entities;
using DBL.Models;
using DBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uttambsolutionsdesktop.Views;
using DBL.Helpers;

namespace Uttambsolutionsdesktop.Presenters
{
    public class StaffPresenter
    {
        Encryptdecrypt sec = new Encryptdecrypt();
        Stringgenerator str = new Stringgenerator();
        private readonly IStaffView _view;
        private readonly string _userId;
        private readonly BL _bl;
        private BindingSource staffBindingSource;
        private IEnumerable<SystemStaffData> staffList;

        public StaffPresenter(IStaffView view, string userId, string connectionString)
        {
            this._view = view;
            _bl = new BL(connectionString);
            _userId = userId;
            this.staffBindingSource = new BindingSource();
            //Subscribe event handler methods to view events
            //this._view.SearchEvent += SearchPet;
            this._view.AddNewEvent += AddNewStaff;
            this._view.EditEvent += LoadSelectedStaffToEdit;
            this._view.DeleteEvent += DeleteSelectedStaff;
            this._view.SaveEvent += SaveStaff;
            //Set staff bindind source
            this._view.SetStaffListBindingSource(staffBindingSource);
            //Load staff list view
            LoadAllStaffList();
            //Show view
            this._view.Show();


        }

        private async void LoadAllStaffList()
        {
            staffList = await _bl.GetAllSystemStaffs();
            staffBindingSource.DataSource = staffList;//Set data source.
        }

        //private void SearchPet(object sender, EventArgs e)
        //{
        //    bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
        //    if (emptyValue == false)
        //        petList = repository.GetByValue(this.view.SearchValue);
        //    else petList = repository.GetAll();
        //    petsBindingSource.DataSource = petList;
        //}

        private async void SaveStaff(object sender, EventArgs e)
        {
            if (_view.Userid==0)
            {
                // Check if any of the required fields are empty
                if (string.IsNullOrWhiteSpace(_view.FirstName) ||
                    string.IsNullOrWhiteSpace(_view.LastName) ||
                    string.IsNullOrWhiteSpace(_view.Phonenumber) ||
                    string.IsNullOrWhiteSpace(_view.Username) ||
                    string.IsNullOrWhiteSpace(_view.Emailaddress) ||
                    string.IsNullOrWhiteSpace(_view.Passwords) ||
                    _view.Roleid == 0)
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }
            }
            else
            {
                if (_view.Roleid == 0)
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }
            }
            
            string Passwordhash = str.RandomString(12);
            string Password = str.RandomString(8).ToString();
            SystemStaff staffData = new SystemStaff();
            staffData.Userid = _view.Userid;
            staffData.FirstName = _view.FirstName;
            staffData.LastName = _view.LastName;
            staffData.Phonenumber = _view.Phonenumber;
            staffData.Username = _view.Username;
            staffData.Emailaddress = _view.Emailaddress;
            staffData.Roleid = _view.Roleid;
            staffData.Passharsh = Passwordhash;
            staffData.Passwords = sec.Encrypt(_view.Passwords, Passwordhash);
            staffData.Isactive = true;
            staffData.Isdeleted = false;
            staffData.Loginstatus = 0;
            staffData.Passwordresetdate = DateTime.Now;
            staffData.Lastlogin = DateTime.Now;
            staffData.Createdby = Convert.ToInt32(_userId);
            staffData.Modifiedby = Convert.ToInt32(_userId);
            staffData.Datecreated = DateTime.Now;
            staffData.Datemodified = DateTime.Now;

            // Call the BL method to save the category
            var resp = await _bl.SaveStaff(staffData);
            // Handle the response accordingly
            if (resp.RespStatus == 0)
            {
                MessageBox.Show(resp.RespMessage);
            }
            else if (resp.RespStatus == 1)
            {
                MessageBox.Show(resp.RespMessage);
            }
            else
            {
                MessageBox.Show(resp.RespMessage);
            }
            // Refresh the staff list
            LoadAllStaffList();
        }
        public async Task<List<SystemRole>> GetRoleData()
        {
            return (List<SystemRole>)await _bl.GetAllSystemRoles(); ;
        }
        private void DeleteSelectedStaff(object sender, EventArgs e)
        {
        }
        private void LoadSelectedStaffToEdit(object sender, EventArgs e)
        {
        }
        private void AddNewStaff(object sender, EventArgs e)
        {
        }
    }
}
