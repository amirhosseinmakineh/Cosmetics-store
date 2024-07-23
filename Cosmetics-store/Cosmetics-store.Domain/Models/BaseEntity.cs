using System.ComponentModel.DataAnnotations;

namespace Cosmetics_store.Domain.Models
{
    public class BaseEntity<Tkey> where Tkey : struct
    {
        [Key]
        public Tkey Id { get; set; }
        public bool IsDelete { get; set; }
        private DateTime createDate;

        public DateTime MyProperty
        {
            get { return createDate; }
            set { createDate = DateTime.Now; }
        }

    }
}
