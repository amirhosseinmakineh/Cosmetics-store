using Cosmetics_store.Domain.Models;
using CosmeticStore.Framwork.Abstractions;
using System.Globalization;
namespace Cosmetics_store.ApplicationService.Command.CategoryCommand
{
    public class GetCategoryCommand:ICommand
    {
        public List<Category> MainCategory { get; set; } = new List<Category>();
        public List<Category> ParentCategory { get; set; } = new List<Category>();
        public List<Category> SubMainCategory { get; set; } = new List<Category>();
        public string Title { get; set; }
        public int Id { get; set; }
        public int? ParentId { get; set; }
    }
}
