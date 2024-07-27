using Microsoft.Extensions.DependencyInjection;

namespace CosmeticStore.Framwork.Abstractions
{
    public class CommandBus:ICommandBus
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
                //handler.Handle();
            };
        }
        public TCommand DisPatch<TCommand>() where TCommand : ICommand
        {
            var handlers = serviceProvider.GetRequiredService<IEnumerable<ICommandHandler<TCommand>>>().ToList();
            var command = Activator.CreateInstance<TCommand>();
                foreach (var handler in handlers)
                {
                    //handler.Handle(command);
                   command =  handler.Handle();
                    return command;
                };
            return command;
        }

        public ICollection<TCommand> DisPatchList<TCommand>() where TCommand : ICommand
        {
            var handlers = serviceProvider.GetRequiredService<IEnumerable<ICommandHandler<TCommand>>>().ToList();
            Type listCommand = typeof(List<TCommand>);
            object command = Activator.CreateInstance(listCommand);
            ICollection<TCommand> commands = (ICollection<TCommand>)command;
            foreach (var handler in handlers)
            {
                commands = handler.Handlelist();
                return commands;
            };
            return commands;
        }
    }
}
