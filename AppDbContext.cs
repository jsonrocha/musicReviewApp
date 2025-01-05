using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicReviewApp.Models;

namespace MusicReviewApp
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Additional custom tables
        public DbSet<Album> Albums { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<CustomList> CustomLists { get; set; }
        public DbSet<Journal> Journals { get; set; }
    }
}
