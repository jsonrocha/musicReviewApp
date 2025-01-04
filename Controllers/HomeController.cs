using Microsoft.AspNetCore.Mvc;

namespace MusicReviewApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Albums"] = new[]
            {
        new { Name = "Album 1", Artist = "Artist 1", ImageUrl = "https://via.placeholder.com/150" },
        new { Name = "Album 2", Artist = "Artist 2", ImageUrl = "https://via.placeholder.com/150" }
        };

            ViewData["Reviews"] = new[]
            {
        new { User = "John Doe", Content = "Amazing album!", Album = "Album 1" },
        new { User = "Jane Smith", Content = "Loved the vibe.", Album = "Album 2" }
    };

            ViewData["Lists"] = new[]
            {
        new { Name = "Best Albums of 2025", Creator = "John Doe" },
        new { Name = "Top 10 Summer Jams", Creator = "Jane Smith" }
    };

            ViewData["Journal"] = new[]
            {
        new { Title = "My Journey into Jazz", Date = DateTime.Now.AddDays(-1) },
        new { Title = "Top 5 Rock Albums", Date = DateTime.Now.AddDays(-3) }
    };

            return View();
        }

    }
}
