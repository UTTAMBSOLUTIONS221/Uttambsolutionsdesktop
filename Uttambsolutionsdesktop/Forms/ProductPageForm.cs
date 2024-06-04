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
using DBL.Models;

namespace Uttambsolutionsdesktop.Forms
{
    public partial class ProductPageForm : UserControl, IProductView
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
            get { return int.TryParse(txtProductId.Text, out int id) ? id : 0; }
            set { txtProductId.Text = value.ToString(); }
        }
        public string ProductName
        {
            get { return txtProductName.Text; }
            set { txtProductName.Text = value; }
        }

        public int UomId { get => Convert.ToInt32(comboBoxUomId.SelectedValue); set => comboBoxUomId.SelectedValue = value; }
        public int CategoryId { get => Convert.ToInt32(comboBoxCategoryId.SelectedValue); set => comboBoxCategoryId.SelectedValue = value; }
        public int TaxCategoryId { get => Convert.ToInt32(comboBoxTaxCategoryId.SelectedValue); set => comboBoxTaxCategoryId.SelectedValue = value; }

        public string? Barcode { get => txtBarcode.Text; set => txtBarcode.Text = value; }
        public decimal Units { get => Convert.ToDecimal(txtUnits.Text); set => txtUnits.Text = value.ToString(); }
        public decimal Price { get => Convert.ToDecimal(txtPrice.Text); set => txtPrice.Text = value.ToString(); }

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


        public void PopulateUomComboBox(List<SystemUoms> uomData)
        {
            comboBoxUomId.DataSource = uomData;
            comboBoxUomId.ValueMember = "UomId"; // Set the value member to the appropriate property name
            comboBoxUomId.DisplayMember = "UomName"; // Set the display member to the appropriate property name
        }

        public void PopulateCategoryComboBox(List<CategoryData> categoryData)
        {
            comboBoxCategoryId.DataSource = categoryData;
            comboBoxCategoryId.ValueMember = "CategoryId"; // Set the value member to the appropriate property name
            comboBoxCategoryId.DisplayMember = "CategoryName"; // Set the display member to the appropriate property name
        }

        public void PopulateTaxCategoryComboBox(List<SystemTaxCategory> taxCategoryData)
        {
            comboBoxTaxCategoryId.DataSource = taxCategoryData;
            comboBoxTaxCategoryId.ValueMember = "TaxCategoryId"; // Set the value member to the appropriate property name
            comboBoxTaxCategoryId.DisplayMember = "TaxCategoryName"; // Set the display member to the appropriate property name
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

            // Populate comboboxes
            PopulateComboboxes();
        }
        private async void PopulateComboboxes()
        {
            // Call presenter methods to retrieve combobox data
            var uomData = await _presenter.GetUomData();
            var categoryData = await _presenter.GetCategoryData();
            var taxCategoryData = await _presenter.GetTaxCategoryData();

            // Populate comboboxes with data
            PopulateUomComboBox(uomData);
            PopulateCategoryComboBox(categoryData);
            PopulateTaxCategoryComboBox(taxCategoryData);
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
