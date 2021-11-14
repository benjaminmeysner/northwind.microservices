namespace Northwind.Products.Domain.Aggregates
{
    public class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int ProductSupplierID { get; set; }

        public int ProductCategoryID { get; set; }

        public string AmountPerUnit { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal UnitsOnOrder { get; set; }
    }
}
