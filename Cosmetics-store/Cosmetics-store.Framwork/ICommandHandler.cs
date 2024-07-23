namespace Cosmetics_store.Framwork
{
    public interface ICommandHandler
    {
        void Handle(ICommand command);
    }
}
