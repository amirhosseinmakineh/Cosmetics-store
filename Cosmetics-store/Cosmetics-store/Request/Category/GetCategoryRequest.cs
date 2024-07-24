using Cosmetics_store.ApplicationService.Command.CategoryCommand;

namespace Cosmetics_store.Request.Category
{
    public class GetCategoryRequest : ConvertToCommand<GetCategoryCommand>
    {
        public string Title { get; set; }
        public int? ParentId { get; set; }

        public GetCategoryCommand ToCommand()
        {
            return new GetCategoryCommand
            {
                Title = Title,
                ParentId = ParentId
            };
        }
    }
}
