using Microsoft.AspNetCore.Identity;

namespace GrentaStore.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string FullName { get; set; }

        public ICollection<UserProducts>? userProduts { get; set; }
        
    }
}
