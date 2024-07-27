using System.ComponentModel.DataAnnotations;

namespace Cosmetics_store.Domain.Models
{
    public class Product:BaseEntity<Guid>
    {
        public Product()
        {
            ProductGalleries = new HashSet<ProductGallery>();
            Colors = new HashSet<Color>();
        }
        [Display(Name="نام محصول ")]
        [Required]
        [MaxLength(16)]
        public string Name { get; set; }
        [Display(Name ="قیمت محصول ")]
        [Required]
        public double Price { get; set; }
        [Display(Name="تصویر محصول ")]
        [Required]
        [MaxLength(32)]
        public string ImageName { get; set; }
        [Display(Name ="معرفی محصول ")]
        [Required]
        public string Introduction { get; set; }
        [Display(Name ="نحوه استفاده ")]
        [Required]
        public string HowToUse { get; set; }
        public int CategoryId { get; set; }
        #region Relation
        public ICollection<ProductGallery> ProductGalleries { get; set; }
        public ICollection< Color> Colors { get; set; }
        public Category Category { get; set; }
        #endregion
    }
}
