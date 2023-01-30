using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Application.DTOs.ProductInfo;
using ShoppingCart.Application.Features.ProductInfos.Requests.Queries;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingCart.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductInfosController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductInfosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //GET: api/<ProductInfosController>
        [HttpGet]
        public async Task<ActionResult<List<ProductInfoListDto>>> Get()
        {
            var productInfos = await _mediator.Send(new GetProductInfoListRequest());
            return Ok(productInfos);
        }

        // GET api/<ProductInfosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductInfosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductInfosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductInfosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
