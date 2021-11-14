namespace Northwind.Products.Service.Commands
{
    using System.Collections.Generic;
    using MediatR;
    using Northwind.Products.Domain.Aggregates;

    public class GetAllProductsCommand : IRequest<IEnumerable<Product>>
    {
    }
}
