using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Windows.Forms;
using DBL.Entities;
using Microsoft.VisualBasic.ApplicationServices;
using Uttambsolutionsdesktop.Presenters;
using Uttambsolutionsdesktop.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
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
        public int MainCategoryId
        {
            get { return int.TryParse(txtMainCategoryId.Text, out int id) ? id : 0; }
            set { txtMainCategoryId.Text = value.ToString(); }
        }
        public string MainCategoryName
        {
            get { return txtMainCategoryName.Text; }
            set { txtMainCategoryName.Text = value; }
        }

        // Properties
        public int FirstCategoryId
        {
            get { return int.TryParse(txtFirstCategoryId.Text, out int id) ? id : 0; }
            set { txtFirstCategoryId.Text = value.ToString(); }
        }
        public string FirstCategoryName
        {
            get { return txtFirstCategoryName.Text; }
            set { txtFirstCategoryName.Text = value; }
        }
        public int FirstMainCategoryId
        {
            get { return int.TryParse(txtFirstMainCategoryId.Text, out int id) ? id : 0; }
            set { txtFirstMainCategoryId.Text = value.ToString(); }
        }

        // Properties
        public int ThirdCategoryId
        {
            get { return int.TryParse(txtThirdCategoryId.Text, out int id) ? id : 0; }
            set { txtThirdCategoryId.Text = value.ToString(); }
        }
        public string ThirdCategoryName
        {
            get { return txtThirdCategoryName.Text; }
            set { txtThirdCategoryName.Text = value; }
        }
        public int ThirdFirstCategoryId
        {
            get { return int.TryParse(txtThirdFirstCategoryId.Text, out int id) ? id : 0; }
            set { txtThirdFirstCategoryId.Text = value.ToString(); }
        }

        // Constructors
        public CategoryPageForm(string userId)
        {
            InitializeComponent();
            _userId = userId;
            _presenter = new CategoryPresenter(this, userId, DatabaseManager.ConnectionString);
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageMainCategoryDetail);
            tabControl1.TabPages.Remove(tabPageFirstCategoryDetail);
            tabControl1.TabPages.Remove(tabPageThirdCategoryDetail);
            dataGridViewMain.DataBindingComplete += DataGridView_MainDataBindingComplete;
            dataGridViewFirst.DataBindingComplete += DataGridView_FirstDataBindingComplete;
            dataGridViewThird.DataBindingComplete += DataGridView_ThirdDataBindingComplete;
        }

        // Methods
        private void AssociateAndRaiseViewEvents()
        {
            btnAddNewMain.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                ClearDetailFields();
                //Userid = 0; // Ensure UserId is set to 0 for new entrie
                tabControl1.TabPages.Remove(tabPageCategoryList);
                tabControl1.TabPages.Remove(tabPageFirstCategoryDetail);
                tabControl1.TabPages.Remove(tabPageThirdCategoryDetail);
                tabControl1.TabPages.Add(tabPageMainCategoryDetail);
                tabPageMainCategoryDetail.Text = "Add Main Category";
            };

            btnEditMain.Click += (sender, e) => EditEvent?.Invoke(this, EventArgs.Empty);
            btnDeleteMain.Click += (sender, e) => DeleteEvent?.Invoke(this, EventArgs.Empty);


            btnAddNewFirst.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                ClearDetailFields();
                //Userid = 0; // Ensure UserId is set to 0 for new entrie
                tabControl1.TabPages.Remove(tabPageCategoryList);
                tabControl1.TabPages.Remove(tabPageMainCategoryDetail);
                tabControl1.TabPages.Remove(tabPageThirdCategoryDetail);
                tabControl1.TabPages.Add(tabPageFirstCategoryDetail);
                tabPageFirstCategoryDetail.Text = "Add First Category";
            };
            btnEditFirst.Click += (sender, e) => EditEvent?.Invoke(this, EventArgs.Empty);
            btnDeleteFirst.Click += (sender, e) => DeleteEvent?.Invoke(this, EventArgs.Empty);


            btnAddNewThird.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                ClearDetailFields();
                //Userid = 0; // Ensure UserId is set to 0 for new entrie
                tabControl1.TabPages.Remove(tabPageCategoryList);
                tabControl1.TabPages.Remove(tabPageMainCategoryDetail);
                tabControl1.TabPages.Remove(tabPageFirstCategoryDetail);
                tabControl1.TabPages.Add(tabPageThirdCategoryDetail);
                tabPageThirdCategoryDetail.Text = "Add Third Category";
            };

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
        private void ClearDetailFields()
        {
            MainCategoryId = 0;
            MainCategoryName = string.Empty;
            FirstCategoryId = 0;
            FirstCategoryName = string.Empty;
            FirstMainCategoryId = 0;
            ThirdCategoryId = 0;
            ThirdCategoryName = string.Empty;
            ThirdFirstCategoryId = 0;
        }

        // Optional method to show message boxes
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
