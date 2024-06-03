using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DBL;
using DBL.Entities;
using Uttambsolutionsdesktop.Forms;
using Uttambsolutionsdesktop.Views;

namespace Uttambsolutionsdesktop.Presenters
{
    public class CategoryPresenter
    {
        private readonly ICategoryView _view;
        private readonly BindingSource _categoryBindingSource;
        private readonly BL _bl;
        private List<Category> _categoryList;
        private AddCategoryForm _addCategoryFormWindow;

        public CategoryPresenter(ICategoryView view,string connectionString)
        {
            _view = view;
            _bl = new BL(connectionString);
            _categoryBindingSource = new BindingSource();
            _view.SetCategoryListBindingSource(_categoryBindingSource);

            _view.SearchEvent += SearchCategory;
            _view.AddNewEvent += AddNewCategory;
            _view.EditEvent += EditCategory;
            _view.DeleteEvent += DeleteCategory;

            LoadAllCategories();
          
        }

        private async void LoadAllCategories()
        {
            _categoryList = (List<Category>)await _bl.GetAllCategories();
            _categoryBindingSource.DataSource = _categoryList;
        }

        private void SearchCategory(object sender, EventArgs e)
        {
            string searchText = _view.SearchText;
            var filteredList = string.IsNullOrWhiteSpace(searchText)
                ? _categoryList
                : _categoryList.FindAll(c => c.CategoryName.Contains(searchText, StringComparison.OrdinalIgnoreCase));

            _categoryBindingSource.DataSource = filteredList;
        }

        private void AddNewCategory(object sender, EventArgs e)
        {

            _addCategoryFormWindow = new AddCategoryForm();
            _addCategoryFormWindow.Show();
        }

        private void EditCategory(object sender, EventArgs e)
        {
            // Logic to edit selected category
            _view.ShowMessage("Edit category clicked");
        }

        private void DeleteCategory(object sender, EventArgs e)
        {
            // Logic to delete selected category
            _view.ShowMessage("Delete category clicked");
        }
    }
}
