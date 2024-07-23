namespace CosmeticStore.Framwork.Abstractions
{
    public interface ICommandHandler<TCommand>
    {
        void Handle(TCommand command);
    }
}
