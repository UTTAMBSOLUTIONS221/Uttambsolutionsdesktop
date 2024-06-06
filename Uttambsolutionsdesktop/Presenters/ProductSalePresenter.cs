// ProductSalePresenter.cs
using DBL.Entities;
using DBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uttambsolutionsdesktop.Views;
using DBL.Models;

namespace Uttambsolutionsdesktop.Presenters
{
    public class ProductSalePresenter
    {
        private readonly IProductSaleView _view;
        private readonly string _userId;
        private readonly BL _bl;
        private BindingSource productsBindingSource;
        private BindingSource productsSaleBindingSource;
        private IEnumerable<SystemProductData> productSearchDataList;
        private IEnumerable<FirstCategory> productSalesDataList;

        public ProductSalePresenter(IProductSaleView view, string userId, string connectionString)
        {
            this._view = view;
            _bl = new BL(connectionString);
            _userId = userId;
            this.productsBindingSource = new BindingSource();
            this.productsSaleBindingSource = new BindingSource();
            //Subscribe event handler methods to view events
            this._view.SearchProductEvent += SearchProduct;
            this._view.SellProductEvent += LoadSelectedProductToSell;
            this._view.PrintSaleEvent += PrintSale;
            this._view.SaveSaleDataEvent += SaveSaleData;
            this._view.CancelSaleEvent += CancelSale;
            //Show view
            this._view.Show();
        }

        private async void SearchProduct(object sender, EventArgs e)
        {
            string searchValue = _view.ProductSearchValue;
            if (!string.IsNullOrWhiteSpace(searchValue))
                productSearchDataList =await  _bl.GetProductsByValue(searchValue);
            productsBindingSource.DataSource = productSearchDataList;
            _view.SetProductSearchDataListBindingSource(productsBindingSource);
        }

        private void PrintSale(object sender, EventArgs e)
        {
            // Implement printing functionality
        }
        private void LoadSelectedProductToSell(object sender, EventArgs e)
        {
        }
        private void SaveSaleData(object sender, EventArgs e)
        {
            // Implement saving sale data functionality
        }

        private void CancelSale(object sender, EventArgs e)
        {
            // Implement canceling sale functionality
        }
    }
}
