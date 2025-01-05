using Microsoft.AspNetCore.Mvc;

namespace MusicReviewApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ListsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetLists()
        {
            var lists = new[]
            {
                new
                {
                    Id = 1,
                    Name = "Best Albums of 2025",
                    Creator = "John Doe",
                    Albums = new[] { "Album 1", "Album 2", "Album 3" }
                },
                new
                {
                    Id = 2,
                    Name = "Top 10 Summer Jams",
                    Creator = "Jane Smith",
                    Albums = new[] { "Album A", "Album B", "Album C" }
                }
            };

            return Ok(lists);
        }

        [HttpPost]
        public IActionResult AddList([FromBody] dynamic list)
        {
            // Example logic to save the list (you'll replace this with real DB logic)
            return CreatedAtAction(nameof(GetLists), new { id = 3 }, list);
        }
    }
}
