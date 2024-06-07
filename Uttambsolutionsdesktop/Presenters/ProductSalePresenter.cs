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
                productSearchDataList =await  _bl.GetProductsByValue(searchValue);
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

        private void OnSaveOrderClicked(object sender, EventArgs e)
        {
            //var order = new CustomerOrder
            //{
            //    OrderCode = _view.OrderCode,
            //    OrderGrossTotal = _view.OrderGrossTotal,
            //    OrderNetTotal = _view.OrderNetTotal,
            //    OrderVatTotal = _view.OrderVatTotal,
            //    Createdby = Convert.ToInt32(_userId), 
            //    Modifiedby = Convert.ToInt32(_userId), 
            //    DateCreated = DateTime.Now,
            //    DateModified = DateTime.Now,
            //    OrderItems = _view.OrderItems
            //};

            // Save order to database (implement this method)
            //SaveSaleData(order);
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
            //decimal OrderGrossTotal = 0;
            //decimal OrderVatTotal = 0;

            //var item = new CustomerOrderItems
            //{
            //    ProductId = _view.ProductId,
            //    ProductPrice = _view.RetailSalePrice,
            //    ProductVat = _view.TaxCategoryValue,
            //    ProductUnits = _view.ProductSellUnits,
            //    ItemGrossTotal = _view.ProductSellTotal,
            //    ItemNetTotal = _view.ProductSellTotal - _view.ProductVatTotal,
            //    ItemVatTotal = _view.ProductVatTotal,
            //    Createdby = Convert.ToInt32(_userId),
            //    Modifiedby = Convert.ToInt32(_userId),
            //    DateCreated = DateTime.Now,
            //    DateModified = DateTime.Now,
            //};

            //item.ItemNetTotal = item.ItemGrossTotal - item.ProductVat;
            //item.ItemVatTotal = item.ProductVat * item.ProductUnits;

            //orderItems.Add(item);
            //orderItemsBindingSource.ResetBindings(false);
        
        CustomerOrderItems customerOrderItemsData = new CustomerOrderItems();
            //customerOrderItemsData.ProductId = _view.ProductId;
            //customerOrderItemsData.ProductPrice = _view.RetailSalePrice;
            //customerOrderItemsData.ProductVat = _view.TaxCategoryValue;
            //customerOrderItemsData.ProductUnits = _view.ProductSellUnits;
            //customerOrderItemsData.ItemGrossTotal = _view.ProductSellTotal;
            //customerOrderItemsData.ItemNetTotal = _view.ProductSellTotal - _view.ProductVatTotal;
            //customerOrderItemsData.ItemVatTotal = _view.ProductVatTotal;
            //customerOrderItemsData.Createdby = Convert.ToInt32(_userId);
            //customerOrderItemsData.Modifiedby = Convert.ToInt32(_userId);
            //customerOrderItemsData.DateCreated = DateTime.Now;
            //customerOrderItemsData.DateModified = DateTime.Now;


            CustomerOrder customerOrderData = new CustomerOrder();
            //customerOrderData.OrderCode = "";
            //customerOrderData.OrderGrossTotal = OrderGrossTotal;
            //customerOrderData.OrderNetTotal = OrderGrossTotal-OrderVatTotal;
            //customerOrderData.OrderVatTotal = OrderVatTotal;
            //customerOrderData.Createdby = Convert.ToInt32(_userId);
            //customerOrderData.Modifiedby = Convert.ToInt32(_userId);
            //customerOrderData.DateCreated = DateTime.Now;
            //customerOrderData.DateModified = DateTime.Now;
        }

        private void CancelSale(object sender, EventArgs e)
        {
            // Implement canceling sale functionality
        }
    }
}
