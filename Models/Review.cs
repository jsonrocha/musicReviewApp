using Microsoft.AspNetCore.Identity;

namespace MusicReviewApp.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; } // Example: 1-5 stars
        public DateTime CreatedAt { get; set; }
    }

}
