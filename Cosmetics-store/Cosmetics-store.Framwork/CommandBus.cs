using Microsoft.
namespace Cosmetics_store.Framwork
{
    public class CommandBus : ICommandBus
    {
        private readonly IServiceProvider serviceProvider;

        public CommandBus(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void Dispatch<TCommand>() where TCommand : ICommand
        {
          var handlers = 
        }
    }
}
