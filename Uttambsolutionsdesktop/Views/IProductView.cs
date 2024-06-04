using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uttambsolutionsdesktop.Views
{
    public class IProductView
    {
        // Properties
        string SearchValue { get; set; }
        int CategoryId { get; set; }
        string CategoryName { get; set; }
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
