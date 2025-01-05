using Microsoft.AspNetCore.Mvc;

namespace MusicReviewApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JournalController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetJournalEntries()
        {
            var journalEntries = new[]
            {
                new { Id = 1, Title = "Top 5 Rock Albums", Date = "2025-01-01", Content = "Explored classic rock albums." },
                new { Id = 2, Title = "Exploring Jazz", Date = "2024-12-28", Content = "Listened to Miles Davis and John Coltrane." }
            };

            return Ok(journalEntries);
        }

        [HttpPost]
        public IActionResult AddJournalEntry([FromBody] dynamic journalEntry)
        {
            // Example logic to save the journal entry (you'll replace this with real DB logic)
            return CreatedAtAction(nameof(GetJournalEntries), new { id = 3 }, journalEntry);
        }
    }
}
