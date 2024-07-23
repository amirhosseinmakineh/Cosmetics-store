using Cosmetics_store.Domain.Models;

namespace Cosmetics_store.Domain.IRepositories
{
    public interface IRepository<Tkey,Tentity> where Tkey: struct where Tentity:BaseEntity<Tkey>
    {
        IQueryable<Tentity> GetAll();
        void Add(Tentity tentity);
        void Update(Tentity tentity);
        Tentity GetById(Tkey tkey);
        void Delete(Tkey tkey);
    }
}
