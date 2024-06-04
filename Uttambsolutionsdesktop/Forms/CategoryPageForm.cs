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
        private readonly string _userId;

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

        public int CategoryId
        {
            get { return int.TryParse(txtCategoryId.Text, out int id) ? id : 0; }
            set { txtCategoryId.Text = value.ToString(); }
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

        public CategoryPageForm(string userId)
        {
            InitializeComponent();
            _userId = userId;
            _presenter = new CategoryPresenter(this, userId, DatabaseManager.ConnectionString);        
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageCategoryDetail);
            btnClose.Click += delegate { this.ParentForm.Close(); };
            // Subscribe to the DataBindingComplete event
            //dataGridView.DataBindingComplete += DataGridView_DataBindingComplete;
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
                if (dataGridView.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridView.SelectedRows[0];
                    if (selectedRow.Cells["CategoryId"].Value != null &&
                        selectedRow.Cells["CategoryName"].Value != null)
                    {
                        CategoryId = Convert.ToInt32(selectedRow.Cells["CategoryId"].Value);
                        CategoryName = selectedRow.Cells["CategoryName"].Value.ToString();
                    }
                }
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

        private void DataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView.Columns.Contains("CategoryId"))
            {
                dataGridView.Columns["CategoryId"].Visible = false;
            }
        }

        // Optional method to show message boxes
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

    }
}
