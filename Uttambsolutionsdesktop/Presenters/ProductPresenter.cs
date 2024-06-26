﻿using DBL.Entities;
using DBL.Models;
using DBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uttambsolutionsdesktop.Views;
using System.Windows.Forms;

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
        public async Task<List<SystemProductBrand>> GetBrandData()
        {
            return (List<SystemProductBrand>)await _bl.GetAllProductBrands(); ;
        }
        public async Task<List<SystemUoms>> GetUomData()
        {
            return (List<SystemUoms>)await _bl.GetAllSystemUoms(); ;
        }
        public async Task<List<MainCategory>> GetMainCategoryData()
        {
            return (List<MainCategory>)await _bl.GetAllMainCategories();
        }
        public async Task<List<FirstCategory>> GetFirstCategoryData()
        {
            return (List<FirstCategory>)await _bl.GetAllFirstCategories();
        }
        public async Task<List<ThirdCategory>> GetThirdCategoryData()
        {
            return (List<ThirdCategory>)await _bl.GetAllThirdCategories();
        }

        public async Task<List<SystemTaxCategory>> GetTaxCategoryData()
        {
            return (List<SystemTaxCategory>)await _bl.GetAllSystemTaxCategory();
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
            productData.ProductId = _view.ProductId;
            productData.ProductName = _view.ProductName;
            productData.UomId = _view.UomId;
            productData.MainCategoryId = _view.MainCategoryId;
            productData.FirstCategoryId = _view.FirstCategoryId;
            productData.BrandId = _view.BrandId;
            productData.TaxCategoryId = _view.TaxCategoryId;
            productData.Barcode = _view.Barcode;
            productData.ProductUnits = _view.ProductUnits;
            productData.WholeSalePrice = _view.WholeSalePrice;
            productData.RetailSalePrice = _view.RetailSalePrice;
            productData.ProfitMargin = _view.RetailSalePrice- _view.WholeSalePrice;
            productData.ProductSize = _view.ProductSize;
            productData.ProductColor = _view.ProductColor;
            productData.ProductWeight = _view.ProductWeight;
            productData.Createdby = Convert.ToInt32(_userId);
            productData.Modifiedby = Convert.ToInt32(_userId);
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
