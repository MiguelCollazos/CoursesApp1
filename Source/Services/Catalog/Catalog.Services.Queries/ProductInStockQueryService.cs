using Catalog.Persistence.Database;
using Catalog.Services.Queries.DTOs;
using Service.Common.Collection;
using Service.Common.Mapping;
using Service.Common.Paging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Services.Queries
{
    public interface IProductInStockQueryServices
    {
        Task<DataCollection<ProductInStockDTO>> GetAllAsync(int page, int take, IEnumerable<int> products = null);

    }
    public class ProductInStockQueryService:IProductInStockQueryServices
    {
        private readonly ApplicationDbContext _context;
        public ProductInStockQueryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<DataCollection<ProductInStockDTO>> GetAllAsync(int page, int take,IEnumerable<int> products=null)
        {
            var collection = await _context.Stocks
                                .Where(x => products == null || products.Contains(x.ProductId))
                                .OrderByDescending(x => x.ProductId)
                                .GetPagedAsync(page, take); 

            return collection.MapTo<DataCollection<ProductInStockDTO>>();
        }
      
    }
}
