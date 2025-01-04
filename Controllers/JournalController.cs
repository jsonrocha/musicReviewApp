using Microsoft.AspNetCore.Mvc;

namespace MusicReviewApp.Controllers
{
    public class JournalController : Controller
    {
        public IActionResult Index()
        {
            var journalEntries = new[]
            {
                new { Title = "Top 5 Rock Albums", Date = "Jan 1, 2025", Content = "Explored classic rock albums." },
                new { Title = "Exploring Jazz", Date = "Dec 28, 2024", Content = "Listened to Miles Davis and John Coltrane." }
            };

            return View(journalEntries);
        }
    }
}
