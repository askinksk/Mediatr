using MediatR;
using MediatrExample.Med.Commands;
using MediatrExample.Med.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatrExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var quary = new GetProductByIdQuery() {Id = id };
            return Ok(await mediator.Send(quary));
        }

        [HttpGet()]
        public async Task<IActionResult> GetAll(Guid id)
        {
            var quary = new GettAllProductQuery();
            return Ok(await mediator.Send(quary));
        }

        [HttpPost()]
        public async Task<IActionResult> Post(CreateProductCommand command)
        {
            var quary = new GettAllProductQuery();
            return Ok(await mediator.Send(command));
        }
    }
}
