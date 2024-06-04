using DBL.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uttambsolutionsdesktop.Views
{
    public class IProductView
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
    }
}
