using Cosmetics_store.ApplicationService.Command.SliderCommand;
using CosmeticStore.Framwork.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cosmetics_store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderController : ControllerBase
    {
        private readonly ICommandBus commandBus;

        public SliderController(ICommandBus commandBus)
        {
            this.commandBus = commandBus;
        }

        [HttpGet]
        public IActionResult GetSlider()
        {
           var command =  commandBus.DisPatch<GetSliderCommand>();
            return Ok(command);
        }
    }
}
