using Catalog.Services.EventHandlers.Comands;
using Catalog.Services.Queries;
using Catalog.Services.Queries.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Common.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Controllers
{
    [ApiController]
    [Route("v1/stocks")]
    public class ProductInStockController : ControllerBase
    {

        private readonly IProductInStockQueryServices _productInStockQueryService;
        private readonly ILogger<ProductInStockController> _logger;
        private readonly IMediator _mediator;

        public ProductInStockController(
            ILogger<ProductInStockController> logger, 
            IMediator mediator,
            IProductInStockQueryServices productInStockQueryService)
        {
            _logger = logger;
            _mediator= mediator;
            _productInStockQueryService = productInStockQueryService;
        }

        [HttpGet]
        public async Task<DataCollection<ProductInStockDTO>> GetAll(int page = 1, int take = 10, string products = null)
        {
            IEnumerable<int> ids = null;

            if (!string.IsNullOrEmpty(products))
            {
                ids = products.Split(',').Select(x => Convert.ToInt32(x));
            }

            return await _productInStockQueryService.GetAllAsync(page, take, ids);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStock(ProductInStockUpdateStockCommand command)
        {
            await _mediator.Publish(command);
            return NoContent();
        }
    }
}
