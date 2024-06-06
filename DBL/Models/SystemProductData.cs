using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Models
{
    public class SystemProductData
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int UomId { get; set; }
        public string? UomName { get; set; }
        public int MainCategoryId { get; set; }
        public string? MainCategoryName { get; set; }
        public int FirstCategoryId { get; set; }
        public string? FirstCategoryName { get; set; }
        public int BrandId { get; set; }
        public string? BrandName { get; set; }
        public int TaxCategoryId { get; set; }
        public string? TaxCategoryName { get; set; }
        public string? Barcode { get; set; }
        public double ProductUnits { get; set; }
        public double WholeSalePrice { get; set; }
        public double RetailSalePrice { get; set; }
        public double ProfitMargin { get; set; }
        public string? ProductSize { get; set; }
        public string? ProductColor { get; set; }
        public double ProductWeight { get; set; }
        public int Createdby { get; set; }
        public int Modifiedby { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
