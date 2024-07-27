using Cosmetics_store.Domain.IRepositories;
using Cosmetics_store.Domain.Models;
using Cosmetics_store.Infrastracture.CosmeticsContext;

namespace Cosmetics_store.Infrastracture.Repositories
{
    public class SliderRepository : Repository<int, Slider>, ISliderRepository
    {
        public SliderRepository(CosmeticsStoreContext context) : base(context)
        {
        }
    }
}
