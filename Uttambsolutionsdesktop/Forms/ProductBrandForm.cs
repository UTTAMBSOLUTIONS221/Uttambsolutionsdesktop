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
using Uttambsolutionsdesktop.Views;
using static Uttambsolutionsdesktop.Program;

namespace Uttambsolutionsdesktop.Forms
{
    public partial class ProductBrandForm : UserControl, IProductBrandView
    {
        private ProductBrandPresenter _presenter;
        private readonly string _userId;

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public int ProductBrandId
        {
            get { return int.TryParse(txtProductBrandId.Text, out int id) ? id : 0; }
            set { txtProductBrandId.Text = value.ToString(); }
        }
        public string ProductBrandName
        {
            get { return txtProductBrandName.Text; }
            set { txtProductBrandName.Text = value; }
        }

        public void SetProductBrandListBindingSource(BindingSource productBrandList)
        {
            dataGridView.DataSource = productBrandList;
            // Ensure the hidden CategoryId column is added
            if (!dataGridView.Columns.Contains("ProductId"))
            {
                dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "ProductBrandId",
                    HeaderText = "ProductBrandId",
                    DataPropertyName = "ProductBrandId", // Ensure this matches the property name in the data source
                    Visible = false
                });
            }
        }

        public ProductBrandForm(string userId)
        {
            InitializeComponent();
            _userId = userId;
            _presenter = new ProductBrandPresenter(this, userId, DatabaseManager.ConnectionString);
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageProductBrandDetail);
            // Subscribe to the DataBindingComplete event
            dataGridView.DataBindingComplete += DataGridView_DataBindingComplete;
        }
        private void AssociateAndRaiseViewEvents()
        {

            btnAddNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                ClearDetailFields();
                ProductBrandId = 0; // Ensure CategoryId is set to 0 for new entries
                tabControl1.TabPages.Remove(tabPageProductBrandList);
                tabControl1.TabPages.Add(tabPageProductBrandDetail);
                tabPageProductBrandDetail.Text = "Add New Brand";
            };

            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                if (dataGridView.SelectedCells.Count > 0)
                {
                    int rowIndex = dataGridView.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView.Rows[rowIndex];
                    if (selectedRow.Cells["ProductBrandId"].Value != null &&
                        selectedRow.Cells["ProductBrandName"].Value != null)
                    {
                        ProductBrandId = Convert.ToInt32(selectedRow.Cells["ProductBrandId"].Value);
                        ProductBrandName = selectedRow.Cells["ProductBrandName"].Value.ToString();
                        
                    }
                }
                tabControl1.TabPages.Remove(tabPageProductBrandList);
                tabControl1.TabPages.Add(tabPageProductBrandDetail);
                tabPageProductBrandDetail.Text = "Edit Product Brand";
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
                tabControl1.TabPages.Remove(tabPageProductBrandDetail);
                tabControl1.TabPages.Add(tabPageProductBrandList);
            };

            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                ClearDetailFields();
                tabControl1.TabPages.Remove(tabPageProductBrandDetail);
                tabControl1.TabPages.Add(tabPageProductBrandList);
            };
        }

        private void DataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView.Columns.Contains("ProductBrandId"))
            {
                dataGridView.Columns["ProductBrandId"].Visible = false;
            }
            if (dataGridView.Columns.Contains("Createdby"))
            {
                dataGridView.Columns["Createdby"].Visible = false;
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
            ProductBrandId = 0;
            ProductBrandName = string.Empty;
        }


        // Optional method to show message boxes
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

    }
}
