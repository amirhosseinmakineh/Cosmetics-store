namespace CosmeticStore.Framwork.Abstractions
{
    public interface ICommandBus
    {
        void DisPatch<TCommand>(TCommand command) where TCommand : ICommand;
        TCommand DisPatch<TCommand>() where TCommand : ICommand;
    }
}
