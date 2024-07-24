namespace Cosmetics_store.Request.Category
{
    public interface ConvertToCommand<TCommand>
    {
        TCommand ToCommand();
    }
}
