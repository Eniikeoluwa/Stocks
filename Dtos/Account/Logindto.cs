using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace myWebApi.Dtos.Account
{
    public class LoginDto 
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}