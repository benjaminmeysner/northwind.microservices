namespace Northwind.Products.Service.Commands
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using Microsoft.EntityFrameworkCore;
    using Northwind.Products.Domain.Aggregates;
    using Northwind.Products.Domain.Context;

    public class GetAllProductsCommandHandler : IRequestHandler<GetAllProductsCommand, IEnumerable<Product>>
    {
        private readonly ProductsContext _context;

        public GetAllProductsCommandHandler(ProductsContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> Handle(GetAllProductsCommand request, CancellationToken cancellationToken)
        {
            return await _context.Products.ToListAsync(cancellationToken: cancellationToken);
        }
    }
}
