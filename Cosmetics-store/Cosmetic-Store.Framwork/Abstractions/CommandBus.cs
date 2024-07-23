using Microsoft.Extensions.DependencyInjection;
namespace CosmeticStore.Framwork.Abstractions
{
    public class CommandBus : ICommandBus
    {
        private readonly IServiceProvider serviceProvider;

        public CommandBus(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void DisPatch<TCommand>(TCommand command) where TCommand : ICommand
        {
            var handlers = serviceProvider.GetRequiredService<IEnumerable<ICommandHandler<TCommand>>>().ToList();
            foreach(var handler in handlers)
            {
                handler.Handle(command);
            };
        }
    }
}
