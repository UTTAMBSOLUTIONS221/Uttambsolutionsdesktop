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
using static Uttambsolutionsdesktop.Program;
using Uttambsolutionsdesktop.Presenters;
using Uttambsolutionsdesktop.Views;

namespace Uttambsolutionsdesktop.Forms
{
    public partial class ProductSaleForm : UserControl, IProductSaleView
    {
        private ProductSalePresenter _presenter;
        private readonly string _userId;

        // Events
        public event EventHandler SearchEvent;
        public event EventHandler PrintEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        // Properties
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
                SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
            };

            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                ClearDetailFields();
            };
        }

        private void DataGridView_ProductDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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
            dataGridViewProducts.DataSource = categoryList;

            // Ensure the hidden CategoryId column is added
            if (!dataGridViewProducts.Columns.Contains("MainCategoryId"))
            {
                dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
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


        private void ClearDetailFields()
        {
          
        }

        // Optional method to show message boxes
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

    }
}
