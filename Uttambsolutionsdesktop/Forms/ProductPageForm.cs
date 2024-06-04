using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Uttambsolutionsdesktop.Program;
using Uttambsolutionsdesktop.Presenters;
using Uttambsolutionsdesktop.Views;

namespace Uttambsolutionsdesktop.Forms
{
    public partial class ProductPageForm : UserControl,IProductView
    {
        private ProductPresenter _presenter;
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

        public int ProductId
        {
            get { return int.TryParse(txtCategoryId.Text, out int id) ? id : 0; }
            set { txtCategoryId.Text = value.ToString(); }
        }
        public string CategoryName
        {
            get { return txtCategoryName.Text; }
            set { txtCategoryName.Text = value; }
        }


        public void SetProductListBindingSource(BindingSource productList)
        {
            dataGridView.DataSource = productList;
            // Ensure the hidden CategoryId column is added
            if (!dataGridView.Columns.Contains("ProductId"))
            {
                dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "ProductId",
                    HeaderText = "ProductId",
                    DataPropertyName = "ProductId", // Ensure this matches the property name in the data source
                    Visible = false
                });
            }
        }

        public ProductPageForm(string userId)
        {
            InitializeComponent();
            _userId = userId;
            _presenter = new ProductPresenter(this, userId, DatabaseManager.ConnectionString);
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageProductDetail);
            // Subscribe to the DataBindingComplete event
            dataGridView.DataBindingComplete += DataGridView_DataBindingComplete;
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
                ClearDetailFields();
                ProductId = 0; // Ensure CategoryId is set to 0 for new entries
                tabControl1.TabPages.Remove(tabPageProductList);
                tabControl1.TabPages.Add(tabPageProductDetail);
                tabPageProductDetail.Text = "Add New Product";
            };

            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                if (dataGridView.SelectedCells.Count > 0)
                {
                    int rowIndex = dataGridView.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView.Rows[rowIndex];
                    if (selectedRow.Cells["ProductId"].Value != null &&
                        selectedRow.Cells["CategoryName"].Value != null)
                    {
                        ProductId = Convert.ToInt32(selectedRow.Cells["ProductId"].Value);
                        CategoryName = selectedRow.Cells["CategoryName"].Value.ToString();
                    }
                }
                tabControl1.TabPages.Remove(tabPageProductList);
                tabControl1.TabPages.Add(tabPageProductDetail);
                tabPageProductDetail.Text = "Edit Product";
            };

            // CellClick event handler to select the entire row
            dataGridView.CellClick += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    dataGridView.Rows[e.RowIndex].Selected = true;
                }
            };


            btnDelete.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };

            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageProductDetail);
                tabControl1.TabPages.Add(tabPageProductList);
            };

            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                ClearDetailFields();
                tabControl1.TabPages.Remove(tabPageProductDetail);
                tabControl1.TabPages.Add(tabPageProductList);
            };
        }

        private void DataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView.Columns.Contains("CategoryId"))
            {
                dataGridView.Columns["CategoryId"].Visible = false;
            }
        }

        // Method to clear the detail fields
        private void ClearDetailFields()
        {
            ProductId = 0;
            CategoryName = string.Empty;
        }

        // Optional method to show message boxes
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

    }
}
