using Microsoft.AspNetCore.Identity;

namespace MusicReviewApp.Models
{
    public class CustomList
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public ICollection<Album> Albums { get; set; }
    }


}
