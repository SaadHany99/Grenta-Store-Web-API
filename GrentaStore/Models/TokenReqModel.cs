using System.ComponentModel.DataAnnotations;

namespace GrentaStore.Models
{
    public class TokenReqModel
    {
        [Required]
        public string Email { get; set; }
        [Required]

        public string Password { get; set; }
    }
}
