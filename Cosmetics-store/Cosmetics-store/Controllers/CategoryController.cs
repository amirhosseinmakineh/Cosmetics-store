using Cosmetics_store.ApplicationService.Command.CategoryCommand;
using CosmeticStore.Framwork.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Cosmetics_store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICommandBus commandBus;
        public CategoryController(ICommandBus commandBus)
        {
            this.commandBus = commandBus;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var command = commandBus.DisPatch<GetCategoryCommand>();
            return Ok(command);
        }
    }
}
