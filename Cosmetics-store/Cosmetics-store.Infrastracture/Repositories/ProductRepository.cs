using Cosmetics_store.Domain.IRepositories;
using Cosmetics_store.Domain.Models;
using Cosmetics_store.Infrastracture.CosmeticsContext;

namespace Cosmetics_store.Infrastracture.Repositories
{
    public class ProductRepository : Repository<Guid, Product>, IProductRepository
    {
        public ProductRepository(CosmeticsStoreContext context) : base(context)
        {
        }
    }
}
