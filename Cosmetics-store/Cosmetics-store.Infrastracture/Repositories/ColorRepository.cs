using Cosmetics_store.Domain.IRepositories;
using Cosmetics_store.Domain.Models;
using Cosmetics_store.Infrastracture.CosmeticsContext;

namespace Cosmetics_store.Infrastracture.Repositories
{
    public class ColorRepository : Repository<int, Color>, IColorRepository
    {
        public ColorRepository(CosmeticsStoreContext context) : base(context)
        {
        }
    }
}
