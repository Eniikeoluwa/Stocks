using Microsoft.AspNetCore.Identity;

namespace myWebApi.Models
{
    public class AppUser : IdentityUser
    {
        public int MyProperty { get; set; }
    }
}