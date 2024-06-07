using DBL.Entities;
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
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal ProductSellUnits { get; set; }
        public decimal TaxCategoryValue { get; set; }
        public decimal RetailSalePrice { get; set; }
        public decimal ProductSellTotal { get; set; }
        public decimal ProductVatTotal { get; set; }

        // Events
        event EventHandler SearchProductEvent;
        event EventHandler SellProductEvent;
        event EventHandler AddOrderProductEvent;
        event EventHandler PrintSaleEvent;
        event EventHandler SaveSaleDataEvent;
        event EventHandler CancelSaleEvent;



        // Methods
        void SetProductSearchDataListBindingSource(BindingSource productSearchDataList);
        void SetOrderProductDataListBindingSource(BindingSource orderProductSearchDataList);
        void SetProductSaleDataListBindingSource(BindingSource productSaleDataList);
      
        void Show();
        void ShowMessage(string message);
    }
}
