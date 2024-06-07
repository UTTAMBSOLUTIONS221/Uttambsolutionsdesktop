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
using System.Windows.Forms;

namespace Uttambsolutionsdesktop.Presenters
{
    public class ProductSalePresenter
    {
        private readonly IProductSaleView _view;
        private readonly string _userId;
        private readonly BL _bl;
        private BindingSource productsBindingSource;
        private BindingSource orderProductsBindingSource;
        private BindingSource productsSaleBindingSource;
        private IEnumerable<SystemProductData> productSearchDataList;
        private IEnumerable<CustomerOrderItems> orderProductDataList;
        private IEnumerable<FirstCategory> productSalesDataList;

        public ProductSalePresenter(IProductSaleView view, string userId, string connectionString)
        {
            this._view = view;
            _bl = new BL(connectionString);
            _userId = userId;
            this.productsBindingSource = new BindingSource();
            this.orderProductsBindingSource = new BindingSource();
            this.productsSaleBindingSource = new BindingSource();
            //Subscribe event handler methods to view events
            this._view.SearchProductEvent += SearchProduct;
            this._view.SellProductEvent += LoadSelectedProductToSell;
            _view.AddOrderProductEvent += OnAddItemClicked;
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
                productSearchDataList = await _bl.GetProductsByValue(searchValue);
            productsBindingSource.DataSource = productSearchDataList;
            _view.SetProductSearchDataListBindingSource(productsBindingSource);
        }
        private void OnAddItemClicked(object sender, EventArgs e)
        {
            // Create a new item based on view data
            CustomerOrderItems newItem = new CustomerOrderItems
            {
                ProductId = _view.ProductId,
                ProductName = _view.ProductName,
                ProductPrice = _view.RetailSalePrice,
                ProductVat = _view.TaxCategoryValue,
                ProductUnits = _view.ProductSellUnits,
                ItemGrossTotal = _view.ProductSellTotal,
                ItemNetTotal = _view.ProductSellTotal - _view.ProductVatTotal,
                ItemVatTotal = _view.ProductVatTotal,
                Createdby = Convert.ToInt32(_userId),
                Modifiedby = Convert.ToInt32(_userId),
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            };

            // Ensure the data source is initialized as a list
            if (orderProductsBindingSource.DataSource == null)
            {
                orderProductsBindingSource.DataSource = new List<CustomerOrderItems>();
            }

            // Cast the data source to a list and add the new item
            var orderProductList = orderProductsBindingSource.DataSource as List<CustomerOrderItems>;
            orderProductList.Add(newItem);

            // Reset bindings to update the view
            orderProductsBindingSource.ResetBindings(false);

            // Update the view's data source
            _view.SetOrderProductDataListBindingSource(orderProductsBindingSource);
        }

        private void PrintSale(object sender, EventArgs e)
        {
            // Implement printing functionality
        }
        private void LoadSelectedProductToSell(object sender, EventArgs e)
        {
        }
        private async void SaveSaleData(object sender, EventArgs e)
        {

            // Initialize totals
            decimal orderGrossTotal = 0;
            decimal orderVatTotal = 0;
            decimal orderNetTotal = 0;

            // Get the list of order items from the binding source
            var orderProductList = orderProductsBindingSource.DataSource as List<CustomerOrderItems>;
            if (orderProductList == null || !orderProductList.Any())
            {
                MessageBox.Show("No items to save.");
                return;
            }

            // Calculate totals
            foreach (var item in orderProductList)
            {
                orderGrossTotal += item.ItemGrossTotal;
                orderVatTotal += item.ItemVatTotal;
            }
            orderNetTotal = orderGrossTotal - orderVatTotal;

            // Create a new order
            CustomerOrder customerOrderData = new CustomerOrder
            {
                OrderCode = Guid.NewGuid().ToString(), // Generate a unique order code
                OrderGrossTotal = orderGrossTotal,
                OrderNetTotal = orderNetTotal,
                OrderVatTotal = orderVatTotal,
                Createdby = Convert.ToInt32(_userId),
                Modifiedby = Convert.ToInt32(_userId),
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                OrderItems = orderProductList

            };
            // Call the BL method to save the category
            var resp = await _bl.SaveCustomerOrder(customerOrderData);
            // Handle the response accordingly
            if (resp.RespStatus == 0)
            {
                MessageBox.Show(resp.RespMessage);
                _view.SetProductSaleDataListBindingSource(productsSaleBindingSource);
            }
            else if (resp.RespStatus == 1)
            {
                MessageBox.Show(resp.RespMessage);
            }
            else
            {
                MessageBox.Show(resp.RespMessage);
            }
        }

        private void CancelSale(object sender, EventArgs e)
        {
            // Implement canceling sale functionality
        }
    }
}
