using DBL.Entities;
using DBL;
using System;
using System.Collections.Generic;
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
           // this._view.SearchEvent += AddNewCategory;
            //this._view.EditEvent += LoadSelectedCategoryToEdit;
            this._view.SaveSaleDataEvent += SaveSaleData;
            //Show view
            this._view.Show();
        }

        private async void SearchProduct(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this._view.ProductSearchValue);
            if (!emptyValue)
                productSearchDataList = await _bl.GetProductsByValue(this._view.ProductSearchValue);
            else
                productSearchDataList = await _bl.GetAllProducts();
            productsBindingSource.DataSource = productSearchDataList;
        }
        
        //private async void LoadAllFirstCategoriesList()
        //{
        //    firstCategoryList = await _bl.GetAllFirstCategories();
        //    firstCategoryBindingSource.DataSource = firstCategoryList;//Set data source.
        //}
       
        private async void SaveSaleData(object sender, EventArgs e)
        {
            FirstCategory firstCategoryData = new FirstCategory();
            firstCategoryData.Createdby = Convert.ToInt32(_userId);
            firstCategoryData.Modifiedby = Convert.ToInt32(_userId);
            firstCategoryData.DateCreated = DateTime.Now;
            firstCategoryData.DateModified = DateTime.Now;

            // Call the BL method to save the category
            var resp = await _bl.SaveFirstCategory(firstCategoryData);
            // Handle the response accordingly
            if (resp.RespStatus == 0)
            {
                MessageBox.Show(resp.RespMessage);
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

        private void DeleteSelectedCategory(object sender, EventArgs e)
        {
        }
        private void LoadSelectedCategoryToEdit(object sender, EventArgs e)
        {
        }
        private void AddNewCategory(object sender, EventArgs e)
        {
        }
    }
}
