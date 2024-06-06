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
        public string? Product { get; set; }
        public int UomId { get; set; }
        public string? Uom { get; set; }
        public int MainCategoryId { get; set; }
        public string? MainCategory { get; set; }
        public int FirstCategoryId { get; set; }
        public string? FirstCategory { get; set; }
        public int BrandId { get; set; }
        public string? Brand { get; set; }
        public int TaxCategoryId { get; set; }
        public string? TaxCategory { get; set; }
        public string? Barcode { get; set; }
        public decimal Units { get; set; }
        public decimal WholeSalePrice { get; set; }
        public decimal RetailSalePrice { get; set; }
        public decimal ProfitMargin { get; set; }
        public string? ProductSize { get; set; }
        public string? ProductColor { get; set; }
        public decimal ProductWeight { get; set; }
        public string? Createdby { get; set; }
        public string? Modifiedby { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
