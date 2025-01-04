using Microsoft.AspNetCore.Mvc;

namespace MusicReviewApp.Controllers
{
    public class ReviewsController : Controller
    {
        public IActionResult Index()
        {
            var reviews = new[]
            {
                new { User = "John Doe", Album = "Album 1", ReviewText = "Loved it!", Rating = 5 },
                new { User = "Jane Smith", Album = "Album 2", ReviewText = "Not my style.", Rating = 2 }
            };

            return View(reviews);
        }
    }
}
