namespace Cosmetics_store.Framwork
{
    public interface ICommandBus
    {
        void Dispatch<TCommand>() where TCommand : ICommand;
    }
}
