using Microsoft.AspNetCore.Mvc;

namespace MusicReviewApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReviewsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllReviews()
        {
            var reviews = new[]
            {
                new { Id = 1, User = "John Doe", Album = "Album 1", ReviewText = "Loved it!", Rating = 5 },
                new { Id = 2, User = "Jane Smith", Album = "Album 2", ReviewText = "Not my style.", Rating = 2 }
            };

            return Ok(reviews);
        }

        [HttpPost]
        public IActionResult AddReview([FromBody] dynamic review)
        {
            // Example logic to save the review (you'll replace this with real DB logic)
            return CreatedAtAction(nameof(GetAllReviews), new { id = 3 }, review);
        }
    }
}
