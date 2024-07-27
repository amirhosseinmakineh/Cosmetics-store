using Cosmetics_store.ApplicationService.Command.SliderCommand;
using Cosmetics_store.ApplicationService.Contract.Cdn;
using Cosmetics_store.Domain.IRepositories;
using CosmeticStore.Framwork.Abstractions;

namespace Cosmetics_store.ApplicationService.CommandHandler.Slider
{
    public class SliderCommandHandler : ICommandHandler<GetSliderCommand>
    {
        private readonly ISliderRepository sliderRepository;

        public SliderCommandHandler(ISliderRepository sliderRepository)
        {
            this.sliderRepository = sliderRepository;
        }
        public void Handle(GetSliderCommand command)
        {
            throw new NotImplementedException();
        }

        public GetSliderCommand Handle()
        {
            throw new NotImplementedException();
        }

        public GetSliderCommand HandleList()
        {
            var imageName = CdnConfiguration.FileUrl;
            var images = sliderRepository.GetAll().Select(x => x.ImageName).ToList();
            var command = new GetSliderCommand();
            foreach(var image in images)
            {
                var imagePath = Path.Combine(Directory.GetCurrentDirectory(), imageName + image);
                command.ImageNames.Add(imagePath);
            }
            return command;
        }

        public ICollection<GetSliderCommand> Handlelist()
        {
            throw new NotImplementedException();
        }
    }
}
