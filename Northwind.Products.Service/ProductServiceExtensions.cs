namespace Northwind.Products.Service
{
    using System.Reflection;
    using MediatR;
    using Microsoft.Extensions.DependencyInjection;
    using Northwind.Products.Domain.Context;

    public static class ProductServiceExtensions
    {
        public static IServiceCollection AddProductService(this IServiceCollection collection, string connectionString)
        {
            collection.AddProductsContext(connectionString, runMigrations: true);
            collection.AddMediatR(Assembly.GetExecutingAssembly());
            collection.AddTransient<IProductService, ProductService>();
            return collection;
        }
    }
}
