using Cosmetics_store.ApplicationService.Command.Product;
using CosmeticStore.Framwork.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cosmetics_store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ICommandBus commandBus;

        public ProductController(ICommandBus commandBus)
        {
            this.commandBus = commandBus;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var command = commandBus.DisPatchList<GetMainProductCommand>();
            return Ok(command);
        }
    }
}
