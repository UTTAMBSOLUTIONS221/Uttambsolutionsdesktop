using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uttambsolutionsdesktop.Views
{
    public interface IProductSaleView
    {

        // Properties
        string? ProductSearchValue { get; set; }
      
        // Events
        event EventHandler SearchProductEvent;
        event EventHandler PrintSaleEvent;
        event EventHandler SaveSaleDataEvent;
        event EventHandler CancelSaleEvent;



        // Methods
        //void SetMainCategoryListBindingSource(BindingSource categoryList);
        //void SetFirstCategoryListBindingSource(BindingSource categoryList);
        void Show();
        void ShowMessage(string message);
    }
}
