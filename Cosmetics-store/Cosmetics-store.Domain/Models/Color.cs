using System.ComponentModel.DataAnnotations;

namespace Cosmetics_store.Domain.Models
{
    public class Color:BaseEntity<int>
    {
        [Display(Name="رنگ محصول ")]
        [Required]
        public string Name { get; set; }
        public Guid ProductId { get; set; }
        #region Relations
        public Product Product { get; set; }
        #endregion
    }
}
