using CosmeticStore.Framwork.Abstractions;

namespace Cosmetics_store.ApplicationService.Command.SliderCommand
{
    public class GetSliderCommand : ICommand
    {
        public List<string> ImageNames { get; set; } = new List<string>();
    }
}
