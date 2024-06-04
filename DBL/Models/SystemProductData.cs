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
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public int TaxCategoryId { get; set; }
        public string? TaxCategoryName { get; set; }
        public string? Barcode { get; set; }
        public decimal Units { get; set; }
        public decimal Price { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
