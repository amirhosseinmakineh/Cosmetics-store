
using Cosmetics_store.ApplicationService.Command.CategoryCommand;
using Cosmetics_store.Domain.IRepositories;
using Cosmetics_store.Domain.Models;
using CosmeticStore.Framwork.Abstractions;

namespace Cosmetics_store.ApplicationService.CommandHandler.Ctaegory
{
    public class GetCategoryCommandHandler : ICommandHandler<GetCategoryCommand>
    {
        private readonly ICategoryRepository repository;

        public GetCategoryCommandHandler(ICategoryRepository repository)
        {
            this.repository = repository;
        }
        public GetCategoryCommand Handle()
        {
            var getcategoryCommand = new GetCategoryCommand();
            var mainCatrgory = repository.GetAll().Where(x=> x.ParentId == null && x.SubParentId == null).ToList();
            getcategoryCommand.MainCategory = mainCatrgory;
            foreach(var parent in mainCatrgory)
            {
                 var parentCategory =  repository.GetAll().Where(x => x.ParentId == parent.Id).Select(x => new Category()
                {
                     Id = x.Id,
                    Title = x.Title,
                    ParentId = x.ParentId
                }).ToList();
                getcategoryCommand.ParentCategory.AddRange(parentCategory);
            }
            foreach (var sub in getcategoryCommand.ParentCategory)
            {
                var subParentCategory = repository.GetAll().Where(x => x.SubParentId == sub.Id ).Select(x => new Category()
                {
                    Id = x.Id,
                    Title = x.Title,
                }).ToList();
                getcategoryCommand.SubMainCategory.AddRange(subParentCategory);
            }
            return getcategoryCommand;
        }

        public void Handle(GetCategoryCommand command)
        {
        }

        public ICollection<GetCategoryCommand> Handlelist()
        {
            throw new NotImplementedException();
        }
    }
}
