using CosmeticStore.Framwork.Abstractions;

namespace Cosmetics_store.ApplicationService.Command.Product
{
    public class GetMainProductCommand : ICommand
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageName { get; set; }
        public int CategoryId { get; set; }
    }
}
