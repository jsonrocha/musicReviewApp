using Microsoft.AspNetCore.Identity;

namespace MusicReviewApp.Models
{
    public class Journal
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string Entry { get; set; }
        public DateTime CreatedAt { get; set; }
    }


}
