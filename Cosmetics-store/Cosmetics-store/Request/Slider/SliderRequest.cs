using Cosmetics_store.ApplicationService.Command.SliderCommand;
using Cosmetics_store.Request.Category;

namespace Cosmetics_store.Request.Slider
{
    public class SliderRequest : ConvertToCommand<GetSliderCommand>
    {
        public List<string> ImageNames { get; set; }
        public GetSliderCommand ToCommand()
        {
            return new GetSliderCommand()
            {
                ImageNames = ImageNames
            };
        }
    }
}
