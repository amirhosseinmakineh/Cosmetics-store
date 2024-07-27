using System.ComponentModel.DataAnnotations;

namespace Cosmetics_store.Domain.Models
{
    public class ProductGallery:BaseEntity<long>
    {
        [Display(Name ="تصویر گالری محصول ")]
        [Required]
        public string ImageName { get; set; }
        public Guid ProductId { get; set; }
        #region Relations
        public Product Product { get; set; }
        #endregion
    }
}
