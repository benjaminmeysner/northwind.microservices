namespace Northwind.Products.Domain.Configuration
{
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Northwind.Products.Domain.Aggregates;

    public class ProductSupplierConfiguration : IEntityTypeConfiguration<ProductSupplier>
    {
        public void Configure(EntityTypeBuilder<ProductSupplier> builder)
        {
            builder.ToTable("ProductSuppliers").HasKey(x => x.ProductSupplerID);
            builder.HasData(SeedData());
        }

        private static IEnumerable<ProductSupplier> SeedData()
        {
            return new[] { new ProductSupplier { ProductSupplerID = 1 } };
        }
    }
}
