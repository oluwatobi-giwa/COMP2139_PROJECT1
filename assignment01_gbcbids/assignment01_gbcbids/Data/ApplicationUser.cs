using Microsoft.AspNetCore.Identity;

namespace assignment01_gbcbids.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
        public string? Role { get; set; }
    }
}
