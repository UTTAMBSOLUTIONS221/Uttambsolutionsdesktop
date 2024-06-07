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
        public event EventHandler AddOrderProductEvent;
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
            get { return Convert.ToDecimal(txtProductVat.Text); }
            set { txtProductVat.Text = value.ToString(); }
        }
        public decimal ProductSellUnits
        {
            get { return Convert.ToDecimal(txtProductSaleQuantity.Text); }
            set { txtProductSaleQuantity.Text = value.ToString(); }
        }

        public decimal RetailSalePrice
        {
            get { return Convert.ToDecimal(txtProductPrice.Text); }
            set { txtProductPrice.Text = value.ToString(); }
        }

        public decimal ProductSellTotal
        {
            get { return Convert.ToDecimal(txtSaleTotal.Text); }
            set { txtSaleTotal.Text = value.ToString(); }
        }
        public decimal ProductVatTotal
        {
            get { return Convert.ToDecimal(txtVatTotal.Text); }
            set { txtVatTotal.Text = value.ToString(); }
        }
        private void TxtProductSaleQuantity_TextChanged(object sender, EventArgs e)
        {
            // Call a method or perform any actions you want when the text changes
            // For example, you can update the sale total
            CalculateProductSellTotal();
        }
        private void CalculateProductSellTotal()
        {
            // Check if txtProductSaleQuantity and txtProductPrice contain valid decimal values
            decimal productSellUnits;
            decimal retailSalePrice;
            decimal productVatValue;
            if (decimal.TryParse(txtProductSaleQuantity.Text, out productSellUnits) &&
                decimal.TryParse(txtProductPrice.Text, out retailSalePrice) && decimal.TryParse(txtProductVat.Text, out productVatValue))
            {
                // Calculate the product sell total by multiplying product sell units with retail sale price
                decimal productSellTotal = productSellUnits * retailSalePrice;
                // Calculate the Total Vat Value
                decimal productVatTotal = productSellTotal * (productVatValue/100);
                // Update the txtSaleTotal textbox with the calculated value
                txtSaleTotal.Text = productSellTotal.ToString();
                txtVatTotal.Text = productVatTotal.ToString();
            }
        }
        // Constructors
        public ProductSaleForm(string userId)
        {
            InitializeComponent();
            _userId = userId;
            _presenter = new ProductSalePresenter(this, userId, DatabaseManager.ConnectionString);
            AssociateAndRaiseViewEvents();
            txtProductSaleQuantity.TextChanged += TxtProductSaleQuantity_TextChanged;
            dataGridViewProducts.DataBindingComplete += DataGridView_ProductDataBindingComplete;
            dataGridViewOrderProducts.DataBindingComplete += DataGridView_OrderProductDataBindingComplete;
            dataGridViewProductSales.DataBindingComplete += DataGridView_SalesDataBindingComplete;
        }

        // Methods
        private void AssociateAndRaiseViewEvents()
        {
            btnSearchProduct.Click += delegate
            {
                SearchProductEvent?.Invoke(this, EventArgs.Empty);
                ClearDetailFields();
            };
            txtSearchProduct.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchProductEvent?.Invoke(this, EventArgs.Empty);
                ClearDetailFields();
            };
            // CellClick event handler to select the entire row
            dataGridViewProducts.CellClick += (sender, e) =>
            {
                txtSearchProduct.Text = "";
                ClearDetailFields();
                if (e.RowIndex >= 0)
                {
                    dataGridViewProducts.Rows[e.RowIndex].Selected = true;
                    DataGridViewRow selectedRow = dataGridViewProducts.Rows[e.RowIndex];
                    if (Convert.ToInt32(selectedRow.Cells["ProductId"].Value) >0)
                    {
                        ProductId = Convert.ToInt32(selectedRow.Cells["ProductId"].Value);
                        ProductName = selectedRow.Cells["Product"].Value.ToString();
                        TaxCategoryValue = Convert.ToDecimal(selectedRow.Cells["TaxCategoryValue"].Value);
                        RetailSalePrice = Convert.ToDecimal(selectedRow.Cells["RetailSalePrice"].Value);
                    }
                    else
                    {
                        // Clear the textboxes if the row is empty
                        ClearDetailFields();
                    }
                }
            };

            btnAddOrder.Click += delegate
            {
                AddOrderProductEvent?.Invoke(this, EventArgs.Empty);
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
                if (dataGridView.Columns.Contains("TaxCategoryValue"))
                {
                    dataGridView.Columns["TaxCategoryValue"].Visible = false;
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


        private void DataGridView_OrderProductDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (sender is DataGridView dataGridView)
            {
                if (dataGridView.Columns.Contains("OrderId"))
                {
                    dataGridView.Columns["OrderId"].Visible = false;
                }
                if (dataGridView.Columns.Contains("OrderItemId"))
                {
                    dataGridView.Columns["OrderItemId"].Visible = false;
                }
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
                if (dataGridView.Columns.Contains("TaxCategoryValue"))
                {
                    dataGridView.Columns["TaxCategoryValue"].Visible = false;

                }
                if (dataGridView.Columns.Contains("Createdby"))
                {
                    dataGridView.Columns["Createdby"].Visible = false;
                }
                if (dataGridView.Columns.Contains("Modifiedby"))
                {
                    dataGridView.Columns["Modifiedby"].Visible = false;
                }
                if (dataGridView.Columns.Contains("DateCreated"))
                {
                    dataGridView.Columns["DateCreated"].Visible = false;
                }
                if (dataGridView.Columns.Contains("Datemodified"))
                {
                    dataGridView.Columns["Datemodified"].Visible = false;
                }
            }
        }



        private void ClearDetailFields()
        {
            // Clear the textboxes
            txtProductId.Text = "";
            txtProductName.Text = "";
            txtProductPrice.Text = "";
            txtProductVat.Text = "";
            txtProductSaleQuantity.Text = "";
            txtSaleTotal.Text = "";
            txtVatTotal.Text = "";
            // Clear other textboxes as needed
        }

        // Interface Implementation
        public void SetProductSearchDataListBindingSource(BindingSource productSearchDataList)
        {
            dataGridViewProducts.DataSource = productSearchDataList;

            // Ensure the hidden CategoryId column is added
            if (!dataGridViewProducts.Columns.Contains("ProductId"))
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
        // Interface Implementation
        public void SetOrderProductDataListBindingSource(BindingSource orderProductDataList)
        {
            dataGridViewOrderProducts.DataSource = orderProductDataList;

            // Ensure the hidden CategoryId column is added
            if (!dataGridViewOrderProducts.Columns.Contains("ProductId"))
            {
                dataGridViewOrderProducts.Columns.Add(new DataGridViewTextBoxColumn
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
