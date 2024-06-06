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
        int ProductId { get; set; }
        string? ProductName { get; set; }
        int UomId { get; set; }
        int CategoryId { get; set; }
        int TaxCategoryId { get; set; }
        string? Barcode { get; set; }
        decimal Units { get; set; }
        decimal Price { get; set; }
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
        void PopulateThirdCategoryComboBox(List<ThirdCategory> thirdCategoryData);
        void PopulateTaxCategoryComboBox(List<SystemTaxCategory> taxCategoryData);

    }
}
