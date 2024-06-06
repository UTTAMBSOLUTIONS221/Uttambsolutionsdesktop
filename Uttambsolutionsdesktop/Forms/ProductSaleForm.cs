// ProductSaleForm.cs
using DBL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uttambsolutionsdesktop.Presenters;
using Uttambsolutionsdesktop.Views;
using static Uttambsolutionsdesktop.Program;

namespace Uttambsolutionsdesktop.Forms
{
    public partial class ProductSaleForm : UserControl, IProductSaleView
    {
        private ProductSalePresenter _presenter;
        private readonly string _userId;

        // Events
        public event EventHandler SearchProductEvent;
        public event EventHandler SellProductEvent;
        public event EventHandler PrintSaleEvent;
        public event EventHandler SaveSaleDataEvent;
        public event EventHandler CancelSaleEvent;

        // Properties
        public string ProductSearchValue
        {
            get { return txtSearchProduct.Text; }
            set { txtSearchProduct.Text = value; }
        }

        public int ProductId
        {
            get { return int.TryParse(txtProductId.Text, out int id) ? id : 0; }
            set { txtProductId.Text = value.ToString(); }
        }

        public string? ProductName
        {
            get { return txtProductName.Text; }
            set { txtProductName.Text = value; }
        }
        public decimal TaxCategoryValue
        {
            get { return Convert.ToDecimal(txtProductPrice.Text); }
            set { txtProductPrice.Text = value.ToString(); }
        }
        public decimal RetailSalePrice
        {
            get { return Convert.ToDecimal(txtProductPrice.Text); }
            set { txtProductPrice.Text = value.ToString(); }
        }
        // Constructors
        public ProductSaleForm(string userId)
        {
            InitializeComponent();
            _userId = userId;
            _presenter = new ProductSalePresenter(this, userId, DatabaseManager.ConnectionString);
            AssociateAndRaiseViewEvents();
            dataGridViewProducts.DataBindingComplete += DataGridView_ProductDataBindingComplete;
            dataGridViewProductSales.DataBindingComplete += DataGridView_SalesDataBindingComplete;
        }

        // Methods
        private void AssociateAndRaiseViewEvents()
        {
            btnSearchProduct.Click += delegate
            {
                SearchProductEvent?.Invoke(this, EventArgs.Empty);
            };
            txtSearchProduct.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchProductEvent?.Invoke(this, EventArgs.Empty);
            };
            // CellClick event handler to select the entire row
            dataGridViewProducts.CellClick += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    dataGridViewProducts.Rows[e.RowIndex].Selected = true;
                    DataGridViewRow selectedRow = dataGridViewProducts.Rows[e.RowIndex];
                    if (Convert.ToInt32(selectedRow.Cells["ProductId"].Value) >0)
                    {
                        ProductId = Convert.ToInt32(selectedRow.Cells["ProductId"].Value);
                        ProductName = selectedRow.Cells["Product"].Value.ToString();
                        //TaxCategoryId = Convert.ToInt32(selectedRow.Cells["TaxCategoryId"].Value);
                        RetailSalePrice = Convert.ToDecimal(selectedRow.Cells["RetailSalePrice"].Value);
                    }
                    else
                    {
                        // Clear the textboxes if the row is empty
                        ClearDetailFields();
                    }
                }
            };

            btnSave.Click += delegate
            {
                SaveSaleDataEvent?.Invoke(this, EventArgs.Empty);
            };

            btnCancel.Click += delegate
            {
                CancelSaleEvent?.Invoke(this, EventArgs.Empty);
                ClearDetailFields();
            };
        }

        private void DataGridView_ProductDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (sender is DataGridView dataGridView)
            {
                if (dataGridView.Columns.Contains("ProductId"))
                {
                    dataGridView.Columns["ProductId"].Visible = false;
                }
                if (dataGridView.Columns.Contains("BrandId"))
                {
                    dataGridView.Columns["BrandId"].Visible = false;
                }
                if (dataGridView.Columns.Contains("UomId"))
                {
                    dataGridView.Columns["UomId"].Visible = false;
                }
                if (dataGridView.Columns.Contains("MainCategoryId"))
                {
                    dataGridView.Columns["MainCategoryId"].Visible = false;
                }
                if (dataGridView.Columns.Contains("FirstCategoryId"))
                {
                    dataGridView.Columns["FirstCategoryId"].Visible = false;
                }
                if (dataGridView.Columns.Contains("WholeSalePrice"))
                {
                    dataGridView.Columns["WholeSalePrice"].Visible = false;
                }
                if (dataGridView.Columns.Contains("ProfitMargin"))
                {
                    dataGridView.Columns["ProfitMargin"].Visible = false;
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
        }

        private void DataGridView_SalesDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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

        private void ClearDetailFields()
        {
            // Clear the textboxes
            txtProductId.Text = "";
            txtProductName.Text = "";
            // Clear other textboxes as needed
        }

        // Interface Implementation
        public void SetProductSearchDataListBindingSource(BindingSource productSearchDataList)
        {
            dataGridViewProducts.DataSource = productSearchDataList;

            // Ensure the hidden CategoryId column is added
            if (!dataGridViewProducts.Columns.Contains("MainCategoryId"))
            {
                dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "ProductId",
                    HeaderText = "ProductId",
                    DataPropertyName = "ProductId", // Ensure this matches the property name in the data source
                    Visible = false
                });
            }
        }

        public void SetFirstCategoryListBindingSource(BindingSource categoryList)
        {
            dataGridViewProductSales.DataSource = categoryList;

            if (!dataGridViewProductSales.Columns.Contains("FirstCategoryId"))
            {
                dataGridViewProductSales.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "FirstCategoryId",
                    HeaderText = "FirstCategoryId",
                    DataPropertyName = "FirstCategoryId", // Ensure this matches the property name in the data source
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
