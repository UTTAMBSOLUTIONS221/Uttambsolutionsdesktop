using DBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uttambsolutionsdesktop.Views
{
    public interface IProductBrandView
    { // Properties
        int ProductBrandId { get; set; }
        string? ProductBrandName { get; set; }
       
        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetProductBrandListBindingSource(BindingSource productBrandList);
        void Show();
    }
}
