namespace Northwind.Products.Service
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Northwind.Products.Domain.Aggregates;

    public interface IProductService
    {
        public Task<IEnumerable<Product>> GetAllAsync();
    }
}
