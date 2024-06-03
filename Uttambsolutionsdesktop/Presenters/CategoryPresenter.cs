using DBL.Entities;
using Uttambsolutionsdesktop.Views;

namespace Uttambsolutionsdesktop.Presenters
{
    public class CategoryPresenter
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICategoryView _view;

        public CategoryPresenter(ICategoryView view, ICategoryRepository categoryRepository)
        {
            _view = view;
            _categoryRepository = categoryRepository;
        }

        public void LoadCategories()
        {
            List<Category> categories = _categoryRepository.GetCategories();
            _view.DisplayCategories(categories);
        }

        public void AddCategory(Category category)
        {
            _categoryRepository.AddCategory(category);
            LoadCategories(); // Reload categories after addition
        }

        public void UpdateCategory(Category category)
        {
            _categoryRepository.UpdateCategory(category);
            LoadCategories(); // Reload categories after update
        }

        public void DeleteCategory(int categoryId)
        {
            _categoryRepository.DeleteCategory(categoryId);
            LoadCategories(); // Reload categories after deletion
        }
    }
}
