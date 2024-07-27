using Cosmetics_store.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Cosmetics_store.Infrastracture.CosmeticsContext
{
    public class CosmeticsStoreContext:DbContext
    {
        public CosmeticsStoreContext(DbContextOptions<CosmeticsStoreContext> options):base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<ProductGallery> ProductGalleries { get; set; }
        public DbSet<Color> Colors { get; set; }
    }
}
