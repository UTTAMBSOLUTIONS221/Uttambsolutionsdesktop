using DBL.Entities;
using DBL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uttambsolutionsdesktop.Views
{
    public interface IProductView
    {
        // Properties
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int UomId { get; set; }
        public int MainCategoryId { get; set; }
        public int FirstCategoryId { get; set; }
        public int BrandId { get; set; }
        public int TaxCategoryId { get; set; }
        public string? Barcode { get; set; }
        public decimal ProductUnits { get; set; }
        public decimal WholeSalePrice { get; set; }
        public decimal RetailSalePrice { get; set; }
        public string? ProductSize { get; set; }
        public string? ProductColor { get; set; }
        public decimal ProductWeight { get; set; }
        string? SearchValue { get; set; }
        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetProductListBindingSource(BindingSource productList);
        void Show();

        // Methods to populate comboboxes
        void PopulateUomComboBox(List<SystemUoms> uomData);
        void PopulateMainCategoryComboBox(List<MainCategory> mainCategoryData);
        void PopulateFirstCategoryComboBox(List<FirstCategory> firstCategoryData);
        void PopulateTaxCategoryComboBox(List<SystemTaxCategory> taxCategoryData);

    }
}
