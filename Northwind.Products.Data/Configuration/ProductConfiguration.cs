namespace Northwind.Products.Domain.Configuration
{
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Northwind.Products.Domain.Aggregates;

    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products").HasKey(x => x.ProductID);
            builder.HasData(SeedData());
        }

        private static IEnumerable<Product> SeedData()
        {
            return new[] { new Product { ProductID = 1, ProductCategoryID = 1, ProductSupplierID = 1, ProductName = "Seiko Gold Watch", UnitPrice = 44.99m } };
        }
    }
}
