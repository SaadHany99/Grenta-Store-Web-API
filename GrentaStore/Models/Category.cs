using System.ComponentModel.DataAnnotations;

namespace GrentaStore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Product>? products { get; set; }
    }
}
