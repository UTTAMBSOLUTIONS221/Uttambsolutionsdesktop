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
    public class ProductPresenter
    {
        private readonly IProductView _view;
        private readonly string _userId;
        private readonly BL _bl;
        private BindingSource productBindingSource;
        private IEnumerable<CategoryData> categoryList;

        public ProductPresenter(IProductView view, string userId, string connectionString)
        {
            this._view = view;
            _bl = new BL(connectionString);
            _userId = userId;
            this.productBindingSource = new BindingSource();
            //Subscribe event handler methods to view events
            //this._view.SearchEvent += SearchPet;
            this._view.AddNewEvent += AddNewCategory;
            this._view.EditEvent += LoadSelectedCategoryToEdit;
            this._view.DeleteEvent += DeleteSelectedCategory;
            this._view.SaveEvent += SaveCategory;
            //Set pets bindind source
            this._view.SetProductListBindingSource(productBindingSource);
            //Load pet list view
            LoadAllCategoriesList();
            //Show view
            this._view.Show();


        }

        private async void LoadAllCategoriesList()
        {
            categoryList = await _bl.GetAllCategories();
            productBindingSource.DataSource = categoryList;//Set data source.
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
            LoadAllCategoriesList();
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
