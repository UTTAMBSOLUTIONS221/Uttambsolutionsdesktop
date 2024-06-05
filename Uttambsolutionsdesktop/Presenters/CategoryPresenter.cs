using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DBL;
using DBL.Entities;
using DBL.Models;
using DBL.Repositories;
using Uttambsolutionsdesktop.Forms;
using Uttambsolutionsdesktop.Views;

namespace Uttambsolutionsdesktop.Presenters
{
    public class CategoryPresenter
    {
        private readonly ICategoryView _view;
        private readonly string _userId;
        private readonly BL _bl;
        private BindingSource mainCategoryBindingSource;
        private BindingSource firstCategoryBindingSource;
        private BindingSource thirdCategoryBindingSource;
        private IEnumerable<MainCategory> mainCategoryList;
        private IEnumerable<FirstCategory> firstCategoryList;
        private IEnumerable<ThirdCategory> thirdCategoryList;

        public CategoryPresenter(ICategoryView view,string userId, string connectionString)
        {
            this._view = view;
            _bl = new BL(connectionString);
            _userId = userId;
            this.mainCategoryBindingSource = new BindingSource();
            this.firstCategoryBindingSource = new BindingSource();
            this.thirdCategoryBindingSource = new BindingSource();
            //Subscribe event handler methods to view events

            this._view.AddNewEvent += AddNewCategory;
            this._view.EditEvent += LoadSelectedCategoryToEdit;
            this._view.DeleteEvent += DeleteSelectedCategory;
            this._view.SaveEvent += SaveCategory;
            //Set pets bindind source
            this._view.SetMainCategoryListBindingSource(mainCategoryBindingSource);
            this._view.SetFirstCategoryListBindingSource(firstCategoryBindingSource);
            this._view.SetThirdCategoryListBindingSource(thirdCategoryBindingSource);
            //Load pet list view
            LoadAllMainCategoriesList();
            LoadAllFirstCategoriesList();
            LoadAllThirdCategoriesList();
            //Show view
            this._view.Show();

           
        }

        private async void LoadAllMainCategoriesList()
        {
            mainCategoryList = await _bl.GetAllMainCategories();
            mainCategoryBindingSource.DataSource = mainCategoryList;//Set data source.
        }
        private async void LoadAllFirstCategoriesList()
        {
            firstCategoryList = await _bl.GetAllFirstCategories();
            firstCategoryBindingSource.DataSource = firstCategoryList;//Set data source.
        }
        private async void LoadAllThirdCategoriesList()
        {
            thirdCategoryList = await _bl.GetAllThirdCategories();
            thirdCategoryBindingSource.DataSource = thirdCategoryList;//Set data source.
        }
        private async void SaveCategory(object sender, EventArgs e)
        {
            MainCategory mainCategoryData = new MainCategory();
            mainCategoryData.MainCategoryId = _view.MainCategoryId;
            mainCategoryData.MainCategoryName = _view.MainCategoryName;
            mainCategoryData.Createdby = Convert.ToInt32(_userId);
            mainCategoryData.Modifiedby = Convert.ToInt32(_userId);
            mainCategoryData.DateCreated = DateTime.Now;
            mainCategoryData.DateModified = DateTime.Now;

            // Call the BL method to save the category
            var resp = await _bl.SaveMainCategory(mainCategoryData);
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
            // Refresh the category list
            LoadAllMainCategoriesList();
            LoadAllFirstCategoriesList();
            LoadAllThirdCategoriesList();
        }
        private void DeleteSelectedCategory(object sender, EventArgs e)
        {
        }
        private void LoadSelectedCategoryToEdit(object sender, EventArgs e)
        {
        }
        private void AddNewCategory(object sender, EventArgs e)
        {
        }
    }
}
