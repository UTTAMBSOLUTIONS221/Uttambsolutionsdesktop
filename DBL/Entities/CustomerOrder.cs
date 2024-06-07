namespace DBL.Entities
{
    public class CustomerOrder
    {
        public int OrderId { get; set; }
        public string? OrderCode { get; set; }
        public decimal OrderGrossTotal { get; set; }
        public decimal OrderNetTotal { get; set; }
        public decimal OrderVatTotal { get; set; }
        public int Createdby { get; set; }
        public int Modifiedby { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public List<CustomerOrderItems>? OrderItems { get; set; }
    }
    public class CustomerOrderItems
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductVat { get; set; }
        public decimal ProductUnits { get; set; }
        public decimal ItemGrossTotal { get; set; }
        public decimal ItemNetTotal { get; set; }
        public decimal ItemVatTotal { get; set; }
        public int Createdby { get; set; }
        public int Modifiedby { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }

}
