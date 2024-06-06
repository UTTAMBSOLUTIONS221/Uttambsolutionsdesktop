using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Windows.Forms;
using DBL.Entities;
using DBL.Models;
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
        public event EventHandler SaveMainEvent;
        public event EventHandler SaveFirstEvent;
        public event EventHandler SaveThirdEvent;
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
        public int FirstMainCategoryId { get => Convert.ToInt32(comboFirstMainCategoryId.SelectedValue); set => comboFirstMainCategoryId.SelectedValue = value; }
        // Constructors
        public CategoryPageForm(string userId)
        {
            InitializeComponent();
            _userId = userId;
            _presenter = new CategoryPresenter(this, userId, DatabaseManager.ConnectionString);
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageMainCategoryDetail);
            tabControl1.TabPages.Remove(tabPageFirstCategoryDetail);
            dataGridViewMain.DataBindingComplete += DataGridView_MainDataBindingComplete;
            dataGridViewFirst.DataBindingComplete += DataGridView_FirstDataBindingComplete;

            // Populate comboboxes
            PopulateComboboxes();
        }
        private async void PopulateComboboxes()
        {
            // Call presenter methods to retrieve combobox data
            var mainCategoryData = await _presenter.GetAllMainCategories();
            var firstCategoryData = await _presenter.GetAllFirstCategories();

            // Populate comboboxes with data
            PopulateFirstMainCategoryComboBox(mainCategoryData);
        }
        public void PopulateFirstMainCategoryComboBox(List<MainCategory> mainCategoryData)
        {
            // Create a new list to hold the modified role data
            List<MainCategory> modifiedMainCategoryData = new List<MainCategory>(mainCategoryData);

            // Insert a default selection option at the beginning of the list
            modifiedMainCategoryData.Insert(0, new MainCategory { MainCategoryId = 0, MainCategoryName = "Select Category" });

            // Bind the modified role data to the ComboBox
            comboFirstMainCategoryId.DataSource = modifiedMainCategoryData;
            comboFirstMainCategoryId.ValueMember = "MainCategoryId";
            comboFirstMainCategoryId.DisplayMember = "MainCategoryName";
            // Select the correct value based on the Roleid property
            comboFirstMainCategoryId.SelectedValue = FirstMainCategoryId;
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
                tabControl1.TabPages.Add(tabPageMainCategoryDetail);
                tabPageMainCategoryDetail.Text = "Add Main Category";
            };
            btnEditMain.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                if (dataGridViewMain.SelectedCells.Count > 0)
                {
                    int rowIndex = dataGridViewMain.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewMain.Rows[rowIndex];
                    if (selectedRow.Cells["MainCategoryId"].Value != null &&
                        selectedRow.Cells["MainCategoryName"].Value != null)
                    {
                        MainCategoryId = Convert.ToInt32(selectedRow.Cells["MainCategoryId"].Value);
                        MainCategoryName = selectedRow.Cells["MainCategoryName"].Value.ToString();
                    }
                }
                tabControl1.TabPages.Remove(tabPageCategoryList);
                tabControl1.TabPages.Remove(tabPageFirstCategoryDetail);
                tabControl1.TabPages.Add(tabPageMainCategoryDetail);
                tabPageMainCategoryDetail.Text = "Edit Main Category";
            };
            btnDeleteMain.Click += (sender, e) => DeleteEvent?.Invoke(this, EventArgs.Empty);


            btnAddNewFirst.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                ClearDetailFields();
                //Userid = 0; // Ensure UserId is set to 0 for new entrie
                tabControl1.TabPages.Remove(tabPageCategoryList);
                tabControl1.TabPages.Remove(tabPageMainCategoryDetail);
                tabControl1.TabPages.Add(tabPageFirstCategoryDetail);
                tabPageFirstCategoryDetail.Text = "Add First Category";
            };
            btnEditFirst.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                if (dataGridViewFirst.SelectedCells.Count > 0)
                {
                    int rowIndex = dataGridViewFirst.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewFirst.Rows[rowIndex];
                    if (selectedRow.Cells["FirstCategoryId"].Value != null &&
                        selectedRow.Cells["MainCategoryId"].Value != null &&
                        selectedRow.Cells["FirstCategoryName"].Value != null)
                    {
                        FirstCategoryId = Convert.ToInt32(selectedRow.Cells["FirstCategoryId"].Value);
                        FirstMainCategoryId = Convert.ToInt32(selectedRow.Cells["MainCategoryId"].Value);
                        FirstCategoryName = selectedRow.Cells["FirstCategoryName"].Value.ToString();
                    }
                }
                tabControl1.TabPages.Remove(tabPageCategoryList);
                tabControl1.TabPages.Remove(tabPageMainCategoryDetail);
                tabControl1.TabPages.Add(tabPageFirstCategoryDetail);
                tabPageFirstCategoryDetail.Text = "Edit First Category";
            };
            btnDeleteFirst.Click += (sender, e) => DeleteEvent?.Invoke(this, EventArgs.Empty);


            btnSaveMain.Click += delegate
            {
                SaveMainEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageMainCategoryDetail);
                tabControl1.TabPages.Remove(tabPageFirstCategoryDetail);
                tabControl1.TabPages.Add(tabPageCategoryList);
            };

            btnCancelMain.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                ClearDetailFields();
                tabControl1.TabPages.Remove(tabPageMainCategoryDetail);
                tabControl1.TabPages.Remove(tabPageFirstCategoryDetail);
                tabControl1.TabPages.Add(tabPageCategoryList);
            };
            btnSaveFirst.Click += delegate
            {
                SaveFirstEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageMainCategoryDetail);
                tabControl1.TabPages.Remove(tabPageFirstCategoryDetail);
                tabControl1.TabPages.Add(tabPageCategoryList);
            };

            btnCancelFirst.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                ClearDetailFields();
                tabControl1.TabPages.Remove(tabPageMainCategoryDetail);
                tabControl1.TabPages.Remove(tabPageFirstCategoryDetail);
                tabControl1.TabPages.Add(tabPageCategoryList);
            };
        }

        private void DataGridView_MainDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (sender is DataGridView dataGridView)
            {
                if (dataGridView.Columns.Contains("MainCategoryId"))
                {
                    dataGridView.Columns["MainCategoryId"].Visible = false;
                }
                if (dataGridView.Columns.Contains("Createdby"))
                {
                    dataGridView.Columns["Createdby"].Visible = false;
                }
                if (dataGridView.Columns.Contains("Modifiedby"))
                {
                    dataGridView.Columns["Modifiedby"].Visible = false;
                }
                if (dataGridView.Columns.Contains("DateModified"))
                {
                    dataGridView.Columns["DateModified"].Visible = false;
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
                if (dataGridView.Columns.Contains("Createdby"))
                {
                    dataGridView.Columns["Createdby"].Visible = false;
                }
                if (dataGridView.Columns.Contains("Modifiedby"))
                {
                    dataGridView.Columns["Modifiedby"].Visible = false;
                }
                if (dataGridView.Columns.Contains("DateModified"))
                {
                    dataGridView.Columns["DateModified"].Visible = false;
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
                if (dataGridView.Columns.Contains("Createdby"))
                {
                    dataGridView.Columns["Createdby"].Visible = false;
                }
                if (dataGridView.Columns.Contains("Modifiedby"))
                {
                    dataGridView.Columns["Modifiedby"].Visible = false;
                }
                if (dataGridView.Columns.Contains("DateModified"))
                {
                    dataGridView.Columns["DateModified"].Visible = false;
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

        
        private void ClearDetailFields()
        {
            MainCategoryId = 0;
            MainCategoryName = string.Empty;
            FirstCategoryId = 0;
            FirstCategoryName = string.Empty;
            FirstMainCategoryId = 0;
        }

        // Optional method to show message boxes
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
