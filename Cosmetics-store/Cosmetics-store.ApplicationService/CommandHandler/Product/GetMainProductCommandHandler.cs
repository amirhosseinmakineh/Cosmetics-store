using Cosmetics_store.ApplicationService.Command.Product;
using Cosmetics_store.ApplicationService.Contract.Cdn;
using Cosmetics_store.Domain.IRepositories;
using CosmeticStore.Framwork.Abstractions;

namespace Cosmetics_store.ApplicationService.CommandHandler.Product
{
    public class GetMainProductCommandHandler : ICommandHandler<GetMainProductCommand>
    {
        private readonly IProductRepository repository;

        public GetMainProductCommandHandler(IProductRepository repository)
        {
            this.repository = repository;
        }

        public ICollection<GetMainProductCommand> Handlelist()
        {
            var products = repository.GetAll().Select(x => new GetMainProductCommand()
            {
                CategoryId = x.CategoryId,
                ImageName = CdnImageConfiguration.FileUrl + x.ImageName,
                Name = x.Name,
                Price = x.Price
            }).OrderBy(x => x.CategoryId).ToList();
            return products;
        }

        public void Handle(GetMainProductCommand command)
        {
            throw new NotImplementedException();
        }

        public GetMainProductCommand Handle()
        {
            throw new  NotImplementedException();
        }
    }
}
