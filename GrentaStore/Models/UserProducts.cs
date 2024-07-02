using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrentaStore.Models
{
    public class UserProducts
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]

        public string UserId { get; set; }
        public ApplicationUser? User { get; set; }
        [ForeignKey("product")]
        public int ProductId { get; set; }
        public Product? product { get; set; }
        

    }
}
