using CQRS_Example.Aplication;
using CQRS_Example.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRS_Example.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<Unit> AddProduct([FromBody] ProductCreate.Command command)
        {
            return await _mediator.Send(command);
        }

        [HttpGet]
        public async Task<List<Product>> GetAllProducts()
        {
            var query = new ProductCollection.Query();
            return await _mediator.Send(query);
        }
    }
}
