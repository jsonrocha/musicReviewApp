using Microsoft.AspNetCore.Identity;

namespace MusicReviewApp.Models
{
    public class User : IdentityUser
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } 
    }

}
