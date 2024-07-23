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
    }
}
