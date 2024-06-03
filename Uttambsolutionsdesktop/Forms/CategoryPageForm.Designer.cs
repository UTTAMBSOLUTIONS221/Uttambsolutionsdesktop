using DBL.Entities;
using Uttambsolutionsdesktop.Presenters;
using Uttambsolutionsdesktop.Views;

namespace Uttambsolutionsdesktop.Forms
{
    public partial class CategoryPageForm : Form, ICategoryView
    {
        private readonly CategoryPresenter _presenter;

        public CategoryPageForm(ICategoryRepository categoryRepository)
        {
            InitializeComponent();
            _presenter = new CategoryPresenter(this, categoryRepository);
            _presenter.LoadCategories();
        }

        public void DisplayCategories(List<Category> categories)
        {
            dataGridViewCategories.DataSource = categories;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Open a form for adding a new category
            // Implement as needed
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Implement as needed
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Implement as needed
        }
    }
}