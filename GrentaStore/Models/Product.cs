using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrentaStore.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        [ForeignKey("category")]
        public int Categ_Id { get; set; }

        public Category? category { get; set; }

        public ICollection<UserProducts>? userProducts { get; set; }
    }
}
