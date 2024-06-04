using DBL.Entities;
using DBL.Models;
using DBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uttambsolutionsdesktop.Views;

namespace Uttambsolutionsdesktop.Presenters
{
    public class ProductPresenter
    {
        private readonly IProductView _view;
        private readonly string _userId;
        private readonly BL _bl;
        private BindingSource productBindingSource;
        private IEnumerable<SystemProductData> productList;

        public ProductPresenter(IProductView view, string userId, string connectionString)
        {
            this._view = view;
            _bl = new BL(connectionString);
            _userId = userId;
            this.productBindingSource = new BindingSource();
            //Subscribe event handler methods to view events
            //this._view.SearchEvent += SearchPet;
            this._view.AddNewEvent += AddNewProduct;
            this._view.EditEvent += LoadSelectedProductToEdit;
            this._view.DeleteEvent += DeleteSelectedProduct;
            this._view.SaveEvent += SaveProduct;
            //Set pets bindind source
            this._view.SetProductListBindingSource(productBindingSource);
            //Load pet list view
            LoadAllProductsList();
            //Show view
            this._view.Show();


        }

        private async void LoadAllProductsList()
        {
            productList = await _bl.GetAllProducts();
            productBindingSource.DataSource = productList;//Set data source.
        }

        //private void SearchPet(object sender, EventArgs e)
        //{
        //    bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
        //    if (emptyValue == false)
        //        petList = repository.GetByValue(this.view.SearchValue);
        //    else petList = repository.GetAll();
        //    petsBindingSource.DataSource = petList;
        //}

        private async void SaveProduct(object sender, EventArgs e)
        {
            SystemProduct productData = new SystemProduct();
            productData.CategoryId = _view.CategoryId;
            productData.ProductName = _view.ProductName;
            productData.CreatedBy = Convert.ToInt32(_userId);
            productData.ModifiedBy = Convert.ToInt32(_userId);
            productData.DateCreated = DateTime.Now;
            productData.DateModified = DateTime.Now;

            // Call the BL method to save the category
            var resp = await _bl.SaveProduct(productData);
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
            // Refresh the product list
            LoadAllProductsList();
        }
        private void DeleteSelectedProduct(object sender, EventArgs e)
        {
        }
        private void LoadSelectedProductToEdit(object sender, EventArgs e)
        {
        }
        private void AddNewProduct(object sender, EventArgs e)
        {
        }
    }
}
