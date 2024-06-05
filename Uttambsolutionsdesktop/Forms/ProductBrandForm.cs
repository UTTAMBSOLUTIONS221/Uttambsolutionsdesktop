using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uttambsolutionsdesktop.Presenters;
using static Uttambsolutionsdesktop.Program;

namespace Uttambsolutionsdesktop.Forms
{
    public partial class ProductBrandForm : UserControl
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

        public int BrandId
        {
            get { return int.TryParse(txtProductId.Text, out int id) ? id : 0; }
            set { txtProductId.Text = value.ToString(); }
        }
        public string BrandName
        {
            get { return txtProductName.Text; }
            set { txtProductName.Text = value; }
        }
        public ProductBrandForm(string userId)
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
                        selectedRow.Cells["ProductName"].Value != null &&
                        selectedRow.Cells["UomId"].Value != null &&
                        selectedRow.Cells["CategoryId"].Value != null &&
                        selectedRow.Cells["TaxCategoryId"].Value != null &&
                        selectedRow.Cells["Barcode"].Value != null &&
                        selectedRow.Cells["Units"].Value != null &&
                        selectedRow.Cells["Price"].Value != null)
                    {
                        ProductId = Convert.ToInt32(selectedRow.Cells["ProductId"].Value);
                        ProductName = selectedRow.Cells["ProductName"].Value.ToString();
                        UomId = Convert.ToInt32(selectedRow.Cells["UomId"].Value);
                        CategoryId = Convert.ToInt32(selectedRow.Cells["CategoryId"].Value);
                        TaxCategoryId = Convert.ToInt32(selectedRow.Cells["TaxCategoryId"].Value);
                        Barcode = selectedRow.Cells["Barcode"].Value.ToString();
                        Units = Convert.ToDecimal(selectedRow.Cells["Units"].Value);
                        Price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);
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
            if (dataGridView.Columns.Contains("ProductId"))
            {
                dataGridView.Columns["ProductId"].Visible = false;
            }
            if (dataGridView.Columns.Contains("UomId"))
            {
                dataGridView.Columns["UomId"].Visible = false;
            }
            if (dataGridView.Columns.Contains("CategoryId"))
            {
                dataGridView.Columns["CategoryId"].Visible = false;
            }
            if (dataGridView.Columns.Contains("TaxCategoryId"))
            {
                dataGridView.Columns["TaxCategoryId"].Visible = false;
            }
            if (dataGridView.Columns.Contains("Modifiedby"))
            {
                dataGridView.Columns["Modifiedby"].Visible = false;
            }
            if (dataGridView.Columns.Contains("Datemodified"))
            {
                dataGridView.Columns["Datemodified"].Visible = false;
            }
        }

        // Method to clear the detail fields
        private void ClearDetailFields()
        {
            ProductId = 0;
            ProductName = string.Empty;
            UomId = 0;
            CategoryId = 0;
            TaxCategoryId = 0;
            Barcode = string.Empty;
            Units = 0;
            Price = 0;
        }


        // Optional method to show message boxes
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

    }
}
