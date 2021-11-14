namespace Northwind.Products.Domain.Context
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class ProductsContextExtensions
    {
        public static IServiceCollection AddProductsContext(this IServiceCollection collection, string connectionString, bool runMigrations = false)
        {
            collection.AddDbContext<ProductsContext>(options => options.UseSqlServer(connectionString));
            if (runMigrations)
            {
                ProductsContext context = collection.BuildServiceProvider().GetService<ProductsContext>();
                context?.Database.Migrate(); // Need a better way of doing this, using add-migration.
            }

            return collection;
        }
    }
}
