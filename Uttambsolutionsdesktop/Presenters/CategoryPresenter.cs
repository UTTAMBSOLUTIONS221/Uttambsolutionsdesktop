using DBL.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Uttambsolutionsdesktop.Models;
using Uttambsolutionsdesktop.Views;

namespace Uttambsolutionsdesktop.Presenters
{
    public class CategoryPresenter
    {
        private readonly ICategoryView _view;
        private readonly ICategoryRepository _repository;
        private readonly BindingSource _categoryBindingSource;
        private IEnumerable<Category> _categoryList;

        public CategoryPresenter(ICategoryView view, ICategoryRepository repository)
        {
            _categoryBindingSource = new BindingSource();
            _view = view;
            _repository = repository;

            // Subscribe event handler methods to view events
            _view.SearchEvent += SearchCategory;
            _view.AddNewEvent += AddNewCategory;
            _view.EditEvent += LoadSelectedCategoryToEdit;
            _view.DeleteEvent += DeleteSelectedCategory;
            _view.SaveEvent += SaveCategory;
            _view.CancelEvent += CancelAction;

            // Set category binding source
            _view.SetCategoryListBindingSource(_categoryBindingSource);

            // Load category list view
            LoadAllCategories();

            // Show view
            _view.Show();
        }

        private void LoadAllCategories()
        {
            _categoryList = _repository.GetAll();
            _categoryBindingSource.DataSource = _categoryList;
        }

        private void SearchCategory(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(_view.SearchValue);
            if (!emptyValue)
                _categoryList = _repository.GetByValue(_view.SearchValue);
            else
                _categoryList = _repository.GetAll();
            _categoryBindingSource.DataSource = _categoryList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            // Implementation for cancel action
        }

        private void SaveCategory(object sender, EventArgs e)
        {
            // Implementation for save action
        }

        private void DeleteSelectedCategory(object sender, EventArgs e)
        {
            // Implementation for delete action
        }

        private void LoadSelectedCategoryToEdit(object sender, EventArgs e)
        {
            // Implementation for loading selected category to edit
        }

        private void AddNewCategory(object sender, EventArgs e)
        {
            // Implementation for adding a new category
        }
    }
}
