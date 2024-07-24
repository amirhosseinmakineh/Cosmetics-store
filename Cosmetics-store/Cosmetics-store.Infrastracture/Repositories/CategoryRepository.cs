using Cosmetics_store.Domain.IRepositories;
using Cosmetics_store.Domain.Models;
using Cosmetics_store.Infrastracture.CosmeticsContext;

namespace Cosmetics_store.Infrastracture.Repositories
{
    public class CategoryRepository : Repository<int, Category>,ICategoryRepository
    {
        public CategoryRepository(CosmeticsStoreContext context) : base(context)
        {
        }
    }
}
