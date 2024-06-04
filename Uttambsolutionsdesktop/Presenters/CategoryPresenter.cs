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
        private readonly BL _bl;
        private BindingSource categoryBindingSource;
        private IEnumerable<CategoryData> categoryList;

        public CategoryPresenter(ICategoryView view, string connectionString)
        {
            this._view = view;
            _bl = new BL(connectionString);

            this.categoryBindingSource = new BindingSource();
            //Subscribe event handler methods to view events
            //this._view.SearchEvent += SearchPet;
            this._view.AddNewEvent += AddNewCategory;
            this._view.EditEvent += LoadSelectedCategoryToEdit;
            this._view.DeleteEvent += DeleteSelectedCategory;
            this._view.SaveEvent += SaveCategory;
            //Set pets bindind source
            this._view.SetCategoryListBindingSource(categoryBindingSource);
            //Load pet list view
            LoadAllCategoriesList();
            //Show view
            this._view.Show();

           
        }

        private async void LoadAllCategoriesList()
        {
            categoryList = await _bl.GetAllCategories();
            categoryBindingSource.DataSource = categoryList;//Set data source.
        }

        //private void SearchPet(object sender, EventArgs e)
        //{
        //    bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
        //    if (emptyValue == false)
        //        petList = repository.GetByValue(this.view.SearchValue);
        //    else petList = repository.GetAll();
        //    petsBindingSource.DataSource = petList;
        //}

        private void SaveCategory(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void DeleteSelectedCategory(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void LoadSelectedCategoryToEdit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void AddNewCategory(object sender, EventArgs e)
        {
            AddNewEvent?.Invoke(this, EventArgs.Empty);
            tabControl1.TabPages.Remove(tabPageCategoryList);
            tabControl1.TabPages.Add(tabPageCategoryDetail);
            tabPageCategoryDetail.Text = "Add New Category";
            _view.AddNewEvent += (sender, args) => ShowCategoryDetailForNew();
        }
    }
}
