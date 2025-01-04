using Microsoft.AspNetCore.Mvc;

namespace MusicReviewApp.Controllers
{
    public class AlbumsController : Controller
    {
        public IActionResult Index()
        {
            var albums = new[]
            {
            new { Name = "Album 1", Artist = "Artist 1", ImageUrl = "https://via.placeholder.com/150" },
            new { Name = "Album 2", Artist = "Artist 2", ImageUrl = "https://via.placeholder.com/150" }
        };
            return View(albums);
        }

    }
}
