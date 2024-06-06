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
using DBL.Entities;

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

        public string? ProductName
        {
            get { return txtProductName.Text; }
            set { txtProductName.Text = value; }
        }

        public int UomId
        {
            get { return Convert.ToInt32(comboBoxUomId.SelectedValue); }
            set { comboBoxUomId.SelectedValue = value; }
        }

        public int MainCategoryId
        {
            get { return Convert.ToInt32(comboBoxMainCategoryId.SelectedValue); }
            set { comboBoxMainCategoryId.SelectedValue = value; }
        }

        public int FirstCategoryId
        {
            get { return Convert.ToInt32(comboBoxFirstCategoryId.SelectedValue); }
            set { comboBoxFirstCategoryId.SelectedValue = value; }
        }

        public int BrandId
        {
            get { return Convert.ToInt32(comboBoxBrandId.SelectedValue); }
            set { comboBoxBrandId.SelectedValue = value; }
        }

        public int TaxCategoryId
        {
            get { return Convert.ToInt32(comboBoxTaxCategoryId.SelectedValue); }
            set { comboBoxTaxCategoryId.SelectedValue = value; }
        }

        public string? Barcode
        {
            get { return txtBarcode.Text; }
            set { txtBarcode.Text = value; }
        }

        public decimal ProductUnits
        {
            get { return Convert.ToDecimal(txtProductUnits.Text); }
            set { txtProductUnits.Text = value.ToString(); }
        }

        public decimal WholeSalePrice
        {
            get { return Convert.ToDecimal(txtWholeSalePrice.Text); }
            set { txtWholeSalePrice.Text = value.ToString(); }
        }

        public decimal RetailSalePrice
        {
            get { return Convert.ToDecimal(txtRetailSalePrice.Text); }
            set { txtRetailSalePrice.Text = value.ToString(); }
        }

        public string? ProductSize
        {
            get { return txtProductSize.Text; }
            set { txtProductSize.Text = value; }
        }

        public string? ProductColor
        {
            get { return txtProductColor.Text; }
            set { txtProductColor.Text = value; }
        }

        public decimal ProductWeight
        {
            get { return Convert.ToDecimal(txtProductWeight.Text); }
            set { txtProductWeight.Text = value.ToString(); }
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

        public void PopulateBrandComboBox(List<SystemProductBrand> brandData)
        {
            // Create a new list to hold the modified brand data
            List<SystemProductBrand> modifiedBrandData = new List<SystemProductBrand>(brandData);

            // Insert a default selection option at the beginning of the list
            modifiedBrandData.Insert(0, new SystemProductBrand { ProductBrandId = 0, ProductBrandName = "Select Brand" });

            // Bind the modified brand data to the ComboBox
            comboBoxBrandId.DataSource = modifiedBrandData;
            comboBoxBrandId.ValueMember = "ProductBrandId";
            comboBoxBrandId.DisplayMember = "ProductBrandName";
        }

        public void PopulateUomComboBox(List<SystemUoms> uomData)
        {
            // Create a new list to hold the modified uom data
            List<SystemUoms> modifiedUomData = new List<SystemUoms>(uomData);

            // Insert a default selection option at the beginning of the list
            modifiedUomData.Insert(0, new SystemUoms { Uomid = 0, UomName = "Select UOM" });

            // Bind the modified uom data to the ComboBox
            comboBoxUomId.DataSource = modifiedUomData;
            comboBoxUomId.ValueMember = "UomId";
            comboBoxUomId.DisplayMember = "UomName";
        }

        public void PopulateMainCategoryComboBox(List<MainCategory> mainCategoryData)
        {
            // Create a new list to hold the modified main category data
            List<MainCategory> modifiedMainCategoryData = new List<MainCategory>(mainCategoryData);

            // Insert a default selection option at the beginning of the list
            modifiedMainCategoryData.Insert(0, new MainCategory { MainCategoryId = 0, MainCategoryName = "Select Main Category" });

            // Bind the modified main category data to the ComboBox
            comboBoxMainCategoryId.DataSource = modifiedMainCategoryData;
            comboBoxMainCategoryId.ValueMember = "MainCategoryId";
            comboBoxMainCategoryId.DisplayMember = "MainCategoryName";
        }

        public void PopulateFirstCategoryComboBox(List<FirstCategory> firstCategoryData)
        {
            // Create a new list to hold the modified first category data
            List<FirstCategory> modifiedFirstCategoryData = new List<FirstCategory>(firstCategoryData);

            // Insert a default selection option at the beginning of the list
            modifiedFirstCategoryData.Insert(0, new FirstCategory { FirstCategoryId = 0, FirstCategoryName = "Select First Category" });

            // Bind the modified first category data to the ComboBox
            comboBoxFirstCategoryId.DataSource = modifiedFirstCategoryData;
            comboBoxFirstCategoryId.ValueMember = "FirstCategoryId";
            comboBoxFirstCategoryId.DisplayMember = "FirstCategoryName";
        }

        public void PopulateTaxCategoryComboBox(List<SystemTaxCategory> taxCategoryData)
        {
            // Create a new list to hold the modified tax category data
            List<SystemTaxCategory> modifiedTaxCategoryData = new List<SystemTaxCategory>(taxCategoryData);

            // Insert a default selection option at the beginning of the list
            modifiedTaxCategoryData.Insert(0, new SystemTaxCategory { TaxCategoryId = 0, TaxCategoryName = "Select Tax Category" });

            // Bind the modified tax category data to the ComboBox
            comboBoxTaxCategoryId.DataSource = modifiedTaxCategoryData;
            comboBoxTaxCategoryId.ValueMember = "TaxCategoryId";
            comboBoxTaxCategoryId.DisplayMember = "TaxCategoryName";
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
            var brandData = await _presenter.GetBrandData();
            var uomData = await _presenter.GetUomData();
            var mainCategoryData = await _presenter.GetMainCategoryData();
            var firstCategoryData = await _presenter.GetFirstCategoryData();
            var thirdCategoryData = await _presenter.GetThirdCategoryData();
            var taxCategoryData = await _presenter.GetTaxCategoryData();

            // Populate comboboxes with data
            PopulateBrandComboBox(brandData);
            PopulateUomComboBox(uomData);
            PopulateMainCategoryComboBox(mainCategoryData);
            PopulateFirstCategoryComboBox(firstCategoryData);
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
                        selectedRow.Cells["Product"].Value != null &&
                        selectedRow.Cells["UomId"].Value != null &&
                        selectedRow.Cells["MainCategoryId"].Value != null &&
                        selectedRow.Cells["FirstCategoryId"].Value != null &&
                        selectedRow.Cells["BrandId"].Value != null &&
                        selectedRow.Cells["TaxCategoryId"].Value != null &&
                        selectedRow.Cells["Barcode"].Value != null &&
                        selectedRow.Cells["Units"].Value != null &&
                        selectedRow.Cells["WholeSalePrice"].Value != null &&
                        selectedRow.Cells["RetailSalePrice"].Value != null &&
                        selectedRow.Cells["ProfitMargin"].Value != null &&
                        selectedRow.Cells["ProductSize"].Value != null &&
                        selectedRow.Cells["ProductColor"].Value != null &&
                        selectedRow.Cells["ProductWeight"].Value != null)
                    {
                        ProductId = Convert.ToInt32(selectedRow.Cells["ProductId"].Value);
                        ProductName = selectedRow.Cells["Product"].Value.ToString();
                        UomId = Convert.ToInt32(selectedRow.Cells["UomId"].Value);
                        MainCategoryId = Convert.ToInt32(selectedRow.Cells["MainCategoryId"].Value);
                        FirstCategoryId = Convert.ToInt32(selectedRow.Cells["FirstCategoryId"].Value);
                        BrandId = Convert.ToInt32(selectedRow.Cells["BrandId"].Value);
                        TaxCategoryId = Convert.ToInt32(selectedRow.Cells["TaxCategoryId"].Value);
                        Barcode = selectedRow.Cells["Barcode"].Value.ToString();
                        ProductUnits = Convert.ToDecimal(selectedRow.Cells["Units"].Value);
                        WholeSalePrice = Convert.ToDecimal(selectedRow.Cells["WholeSalePrice"].Value);
                        RetailSalePrice = Convert.ToDecimal(selectedRow.Cells["RetailSalePrice"].Value);
                        ProductSize = selectedRow.Cells["ProductSize"].Value.ToString();
                        ProductColor = selectedRow.Cells["ProductColor"].Value.ToString();
                        ProductWeight = Convert.ToDecimal(selectedRow.Cells["ProductWeight"].Value);
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

        // Method to clear the detail fields
        public void ClearDetailFields()
        {
            ProductId = 0;
            ProductName = string.Empty;
            UomId = 0;
            MainCategoryId = 0;
            FirstCategoryId = 0;
            BrandId = 0;
            TaxCategoryId = 0;
            Barcode = string.Empty;
            ProductUnits = 0;
            WholeSalePrice = 0;
            RetailSalePrice = 0;
            ProductSize = string.Empty;
            ProductColor = string.Empty;
            ProductWeight = 0;
        }


        // Optional method to show message boxes
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
