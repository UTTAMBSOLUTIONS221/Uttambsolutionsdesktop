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
    public class ProductBrandPresenter
    {
        private readonly IProductBrandView _view;
        private readonly string _userId;
        private readonly BL _bl;
        private BindingSource productBrandBindingSource;
        private IEnumerable<SystemProductBrand> productBrandList;

        public ProductBrandPresenter(IProductBrandView view, string userId, string connectionString)
        {
            this._view = view;
            _bl = new BL(connectionString);
            _userId = userId;
            this.productBrandBindingSource = new BindingSource();
            this._view.AddNewEvent += AddNewProductBrand;
            this._view.EditEvent += LoadSelectedProductBrandToEdit;
            this._view.DeleteEvent += DeleteSelectedProductBrand;
            this._view.SaveEvent += SaveProductBrand;
            //Set pets bindind source
            this._view.SetProductBrandListBindingSource(productBrandBindingSource);
            //Load pet list view
            LoadAllProductBrandList();
            //Show view
            this._view.Show();

        }
        private async void LoadAllProductBrandList()
        {
            productBrandList = await _bl.GetAllProductBrands();
            productBrandBindingSource.DataSource = productBrandList;//Set data source.
        }

        private async void SaveProductBrand(object sender, EventArgs e)
        {
            SystemProductBrand productBrandData = new SystemProductBrand();
            productBrandData.ProductBrandId = _view.ProductBrandId;
            productBrandData.ProductBrandName = _view.ProductBrandName;
            productBrandData.Createdby = Convert.ToInt32(_userId);
            productBrandData.Modifiedby = Convert.ToInt32(_userId);
            productBrandData.DateCreated = DateTime.Now;
            productBrandData.DateModified = DateTime.Now;

            // Call the BL method to save the category
            var resp = await _bl.SaveProductBrand(productBrandData);
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
            LoadAllProductBrandList();
        }
        private void DeleteSelectedProductBrand(object sender, EventArgs e)
        {
        }
        private void LoadSelectedProductBrandToEdit(object sender, EventArgs e)
        {
        }
        private void AddNewProductBrand(object sender, EventArgs e)
        {
        }
    }
}
