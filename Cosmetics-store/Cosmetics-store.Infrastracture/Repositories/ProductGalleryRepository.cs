using Cosmetics_store.Domain.IRepositories;
using Cosmetics_store.Domain.Models;
using Cosmetics_store.Infrastracture.CosmeticsContext;

namespace Cosmetics_store.Infrastracture.Repositories
{
    public class ProductGalleryRepository : Repository<long, ProductGallery>, IProductGalleryRepository
    {
        public ProductGalleryRepository(CosmeticsStoreContext context) : base(context)
        {
        }
    }
}
