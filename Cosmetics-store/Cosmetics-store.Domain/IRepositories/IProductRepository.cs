using Cosmetics_store.Domain.Models;

namespace Cosmetics_store.Domain.IRepositories
{
    public interface IProductRepository:IRepository<Guid,Product>
    {
    }
}
