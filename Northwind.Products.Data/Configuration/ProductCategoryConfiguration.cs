namespace Northwind.Products.Domain.Configuration
{
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Northwind.Products.Domain.Aggregates;

    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategories").HasKey(x => x.ProductCategoryID);
            builder.HasData(SeedData());
        }

        private static IEnumerable<ProductCategory> SeedData()
        {
            return new[] { new ProductCategory { ProductCategoryID = 1 } };
        }
    }
}
