namespace Northwind.Products.Domain.Context
{
    using Microsoft.EntityFrameworkCore;
    using Northwind.Products.Domain.Aggregates;
    using Northwind.Products.Domain.Configuration;

    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions options) : base(options) 
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<ProductCategory> ProductCategories { get; set; }

        public virtual DbSet<ProductSupplier> ProductSuppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductSupplierConfiguration());
        }
    }
}
