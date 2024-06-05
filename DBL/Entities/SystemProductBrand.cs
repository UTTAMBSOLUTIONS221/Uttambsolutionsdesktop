namespace DBL.Entities
{
    public class SystemProductBrand
    {
        public int ProductBrandId { get; set; }
        public string? ProductBrandName { get; set; }
        public int Createdby { get; set; }
        public int Modifiedby { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
