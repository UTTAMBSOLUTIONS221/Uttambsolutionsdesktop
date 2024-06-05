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
        private IEnumerable<CategoryData> categoryList;

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
            categoryList = await _bl.GetAllCategories();
            mainCategoryBindingSource.DataSource = categoryList;//Set data source.
        }
        private async void LoadAllFirstCategoriesList()
        {
            categoryList = await _bl.GetAllCategories();
            firstCategoryBindingSource.DataSource = categoryList;//Set data source.
        }
        private async void LoadAllThirdCategoriesList()
        {
            categoryList = await _bl.GetAllCategories();
            thirdCategoryBindingSource.DataSource = categoryList;//Set data source.
        }
        private async void SaveCategory(object sender, EventArgs e)
        {
            Category categoryData = new Category();
            categoryData.CategoryId = _view.CategoryId; 
            categoryData.CategoryName = _view.CategoryName; 
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
