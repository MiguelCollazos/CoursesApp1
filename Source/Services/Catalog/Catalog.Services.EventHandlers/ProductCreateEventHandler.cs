using Catalog.Persistence.Database;
using Catalog.Services.EventHandlers.Comands;
using CatalogDomain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.Services.EventHandlers
{
    public class ProductCreateEventHandler:INotificationHandler<ProductCreateCommand>
    {
        private readonly ApplicationDbContext _context;


        public ProductCreateEventHandler(
            ApplicationDbContext context)
        {
            _context = context;
        }
         
        public async Task Handle(ProductCreateCommand comand, CancellationToken cancellationToken)
        {
            await _context.AddAsync(new Product
            {
                Name = comand.Name,
                Description = comand.Description,
                Price = (int)comand.Price
            });

            await _context.SaveChangesAsync();
        }

        
    }
}
