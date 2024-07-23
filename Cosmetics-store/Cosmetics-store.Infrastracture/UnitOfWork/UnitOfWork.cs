using Cosmetics_store.Infrastracture.CosmeticsContext;
using Microsoft.EntityFrameworkCore.Storage;
namespace Cosmetics_store.Infrastracture.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CosmeticsStoreContext context;

        public UnitOfWork(CosmeticsStoreContext context)
        {
            this.context = context;
        }

        private IDbContextTransaction transaction;
        public void Begin()
        {
            transaction = context.Database.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void RoleBack()
        {
            transaction.Rollback();
        }
    }
}
