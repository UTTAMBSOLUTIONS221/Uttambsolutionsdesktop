using DBL.Entities;
using DBL.Models;
using DBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uttambsolutionsdesktop.Views;

namespace Uttambsolutionsdesktop.Presenters
{
    public class StaffPresenter
    {
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

        private async void SaveCategory(object sender, EventArgs e)
        {
            Category categoryData = new Category();
         
            categoryData.Createdby = Convert.ToInt32(_userId);
            categoryData.Modifiedby = Convert.ToInt32(_userId);
            categoryData.DateCreated = DateTime.Now;
            categoryData.DateModified = DateTime.Now;

            // Call the BL method to save the category
            var resp = await _bl.SaveCategory(categoryData);
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
