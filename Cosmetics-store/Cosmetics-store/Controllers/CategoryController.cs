using Cosmetics_store.ApplicationService.Command.CategoryCommand;
using Cosmetics_store.Request.Category;
using CosmeticStore.Framwork.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Cosmetics_store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController :ControllerBase
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
            return Created("",command);
        }
    }
}
