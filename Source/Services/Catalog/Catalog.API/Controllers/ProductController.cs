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
    [Route("products")]
    public class ProductController : ControllerBase
    {
        

        private readonly ILogger<ProductController> _logger;
        private readonly IProductQueryService _productQueryService;
        private readonly IMediator _mediator;

        public ProductController(ILogger<ProductController> logger, 
            IProductQueryService productQueryService,
            IMediator mediator)
        {
            _logger = logger;
            _productQueryService= productQueryService;
            _mediator= mediator;
        }

        //Productos
        [HttpGet]
        public async Task<DataCollection<ProductDTO>>GetAll(int page=1,int take=10,string ids=null)
        {
            IEnumerable<int> products = null;

            if (!string.IsNullOrEmpty(ids))
            {
                products = ids.Split(',').Select(x => Convert.ToInt32(x));
            }

            return await _productQueryService.GetAllAsync(page,take,products);
        }

        //ProductID
        [HttpGet("{id}")]
        public async Task<ProductDTO> Get(int id)
        {
            return await _productQueryService.GetAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductCreateCommand comand)
        {
            await _mediator.Publish(comand);
            return Ok();
        }
    }
}
