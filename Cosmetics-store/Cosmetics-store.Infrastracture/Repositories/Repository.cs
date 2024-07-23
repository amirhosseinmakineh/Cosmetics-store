using Cosmetics_store.Domain.IRepositories;
using Cosmetics_store.Domain.Models;
using Cosmetics_store.Infrastracture.CosmeticsContext;

namespace Cosmetics_store.Infrastracture.Repositories
{
    public class Repository<Tkey, TEntity> : IRepository<Tkey, TEntity> where TEntity : BaseEntity<Tkey> where Tkey : struct
    {
        private readonly CosmeticsStoreContext context;

        public Repository(CosmeticsStoreContext context)
        {
            this.context = context;
        }

        public void Add(TEntity tentity)
        {
            context.Add(tentity);
        }

        public void Delete(Tkey tkey)
        {
            var entity = GetById(tkey);
            entity.IsDelete = false;
        }

        public IQueryable<TEntity> GetAll()
        {
            return context.Set<TEntity>();
        }

        public TEntity GetById(Tkey tkey)
        {
            var entity = context.Set<TEntity>().Find(tkey);
            return entity;

        }

        public void Update(TEntity tentity)
        {
            context.Update(tentity);
        }
    }
}
