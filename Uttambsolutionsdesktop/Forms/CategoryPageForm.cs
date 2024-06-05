using System;
using System.Collections.Generic;
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

        // Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        // Properties
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

        // Models
        public List<MainCategory> MainCategories { get; set; }

        // Constructors
        public CategoryPageForm(string userId)
        {
            InitializeComponent();
            _userId = userId;
            _presenter = new CategoryPresenter(this, userId, DatabaseManager.ConnectionString);
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageCategoryDetail);
            dataGridViewMain.DataBindingComplete += DataGridView_MainDataBindingComplete;
            dataGridViewFirst.DataBindingComplete += DataGridView_FirstDataBindingComplete;
            dataGridViewThird.DataBindingComplete += DataGridView_ThirdDataBindingComplete;
        }

        // Methods
        private void AssociateAndRaiseViewEvents()
        {
            btnAddNewMain.Click += (sender, e) => AddNewEvent?.Invoke(this, EventArgs.Empty);
            btnEditMain.Click += (sender, e) => EditEvent?.Invoke(this, EventArgs.Empty);
            btnDeleteMain.Click += (sender, e) => DeleteEvent?.Invoke(this, EventArgs.Empty);

            btnAddNewFirst.Click += (sender, e) => AddNewEvent?.Invoke(this, EventArgs.Empty);
            btnEditFirst.Click += (sender, e) => EditEvent?.Invoke(this, EventArgs.Empty);
            btnDeleteFirst.Click += (sender, e) => DeleteEvent?.Invoke(this, EventArgs.Empty);

            btnAddNewThird.Click += (sender, e) => AddNewEvent?.Invoke(this, EventArgs.Empty);
            btnEditThird.Click += (sender, e) => EditEvent?.Invoke(this, EventArgs.Empty);
            btnDeleteThird.Click += (sender, e) => DeleteEvent?.Invoke(this, EventArgs.Empty);

            btnSave.Click += (sender, e) => SaveEvent?.Invoke(this, EventArgs.Empty);
            btnCancel.Click += (sender, e) => CancelEvent?.Invoke(this, EventArgs.Empty);
        }

        private void DataGridView_MainDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (sender is DataGridView dataGridView)
            {
                if (dataGridView.Columns.Contains("MainCategoryId"))
                {
                    dataGridView.Columns["MainCategoryId"].Visible = false;
                }
            }
        }
        private void DataGridView_FirstDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (sender is DataGridView dataGridView)
            {
                if (dataGridView.Columns.Contains("MainCategoryId"))
                {
                    dataGridView.Columns["MainCategoryId"].Visible = false;
                }
                if (dataGridView.Columns.Contains("FirstCategoryId"))
                {
                    dataGridView.Columns["FirstCategoryId"].Visible = false;
                }
            }
        }
        private void DataGridView_ThirdDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (sender is DataGridView dataGridView)
            {
                if (dataGridView.Columns.Contains("FirstCategoryId"))
                {
                    dataGridView.Columns["FirstCategoryId"].Visible = false;
                }
                if (dataGridView.Columns.Contains("ThirdCategoryId"))
                {
                    dataGridView.Columns["ThirdCategoryId"].Visible = false;
                }
            }
        }

        // Interface Implementation
        public void SetMainCategoryListBindingSource(BindingSource categoryList)
        {
            dataGridViewMain.DataSource = categoryList;

            // Ensure the hidden CategoryId column is added
            if (!dataGridViewMain.Columns.Contains("MainCategoryId"))
            {
                dataGridViewMain.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "MainCategoryId",
                    HeaderText = "MainCategoryId",
                    DataPropertyName = "MainCategoryId", // Ensure this matches the property name in the data source
                    Visible = false
                });
            }
        }
        public void SetFirstCategoryListBindingSource(BindingSource categoryList)
        {
            dataGridViewFirst.DataSource = categoryList;

            if (!dataGridViewFirst.Columns.Contains("FirstCategoryId"))
            {
                dataGridViewFirst.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "FirstCategoryId",
                    HeaderText = "FirstCategoryId",
                    DataPropertyName = "FirstCategoryId", // Ensure this matches the property name in the data source
                    Visible = false
                });
            }
        }

        public void SetThirdCategoryListBindingSource(BindingSource categoryList)
        {
            dataGridViewThird.DataSource = categoryList;

            if (!dataGridViewThird.Columns.Contains("ThirdCategoryId"))
            {
                dataGridViewThird.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "ThirdCategoryId",
                    HeaderText = "ThirdCategoryId",
                    DataPropertyName = "ThirdCategoryId", // Ensure this matches the property name in the data source
                    Visible = false
                });
            }
        }


        // Optional method to show message boxes
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
