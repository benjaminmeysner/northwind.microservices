namespace Northwind.Products.Service
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using MediatR;
    using Northwind.Products.Domain.Aggregates;
    using Northwind.Products.Service.Commands;

    public class ProductService : IProductService
    {
        private readonly IMediator _mediator;

        public ProductService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _mediator.Send(new GetAllProductsCommand());
        }
    }
}
