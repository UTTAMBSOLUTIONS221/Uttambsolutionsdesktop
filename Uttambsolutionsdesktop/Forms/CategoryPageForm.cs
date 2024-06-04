using System;
using System.Windows.Forms;
using DBL.Entities;
using Uttambsolutionsdesktop.Presenters;
using Uttambsolutionsdesktop.Views;
using static Uttambsolutionsdesktop.Program;

namespace Uttambsolutionsdesktop.Forms
{
    public partial class CategoryPageForm : UserControl, ICategoryView
    {
        private CategoryPresenter _presenter;

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Properties
        public string SearchValue
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        public string CategoryName
        {
            get { return txtCategoryName.Text; }
            set { txtCategoryName.Text = value; }
        }

        public void SetCategoryListBindingSource(BindingSource categoryList)
        {
            dataGridView.DataSource = categoryList;
        }

        public CategoryPageForm()
        {
            InitializeComponent();
            _presenter = new CategoryPresenter(this, DatabaseManager.ConnectionString);
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageCategoryDetail);
            btnClose.Click += delegate { this.ParentForm.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            btnAddNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageCategoryList);
                tabControl1.TabPages.Add(tabPageCategoryDetail);
                tabPageCategoryDetail.Text = "Add New Category";
            };

            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageCategoryList);
                tabControl1.TabPages.Add(tabPageCategoryDetail);
                tabPageCategoryDetail.Text = "Edit Category";
            };

            btnDelete.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };

            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageCategoryDetail);
                tabControl1.TabPages.Add(tabPageCategoryList);
            };

            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageCategoryDetail);
                tabControl1.TabPages.Add(tabPageCategoryList);
            };
        }

        // Optional method to show message boxes
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
