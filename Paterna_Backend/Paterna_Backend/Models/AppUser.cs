using Microsoft.AspNetCore.Identity;

namespace Paterna_Backend.Models
{
    public class AppUser:IdentityUser
    {
        public string Fullname { get; set; }
    }
}
