using Microsoft.AspNetCore.Mvc;

namespace MusicReviewApp.Controllers
{
    public class ListsController : Controller
    {
        public IActionResult Index()
        {
            var lists = new[]
            {
                new
                {
                    Name = "Best Albums of 2025",
                    Creator = "John Doe",
                    Albums = new[] { "Album 1", "Album 2", "Album 3" }
                },
                new
                {
                    Name = "Top 10 Summer Jams",
                    Creator = "Jane Smith",
                    Albums = new[] { "Album A", "Album B", "Album C" }
                }
            };

            return View(lists);
        }
    }
}
