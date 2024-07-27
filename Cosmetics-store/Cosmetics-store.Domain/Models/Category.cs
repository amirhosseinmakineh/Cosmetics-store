using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cosmetics_store.Domain.Models
{
    public class Category:BaseEntity<int>
    {
        public Category()
        {
            Parents = new HashSet<Category>();
            Products = new HashSet<Product>();
        }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public int? ParentId { get; set; }
        [ForeignKey("ParentId")]
        public int? SubParentId { get; set; }
        #region Realtions
        [ForeignKey("ParentId")]
        public Category Parent { get; set; }
        public ICollection<Category> Parents { get; set; }
        public ICollection<Product> Products { get; set; }
        #endregion
    }
}
