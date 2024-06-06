namespace DBL.Entities
{
    public class SystemProduct
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int UomId { get; set; }
        public int MainCategoryId { get; set; }
        public int FirstCategoryId { get; set; }
        public int BrandId { get; set; }
        public int TaxCategoryId { get; set; }
        public string? Barcode { get; set; }
        public decimal ProductUnits { get; set; }
        public decimal WholeSalePrice { get; set; }
        public decimal RetailSalePrice { get; set; }
        public decimal ProfitMargin { get; set; }
        public string? ProductSize { get; set; }
        public string? ProductColor { get; set; }
        public decimal ProductWeight { get; set; }
        public int Createdby { get; set; }
        public int Modifiedby { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
