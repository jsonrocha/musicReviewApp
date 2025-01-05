using Microsoft.AspNetCore.Mvc;

namespace MusicReviewApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeApiController : ControllerBase
    {
        [HttpGet("albums")]
        public IActionResult GetAlbums()
        {
            var albums = new[]
            {
                new { Id = 1, Name = "Album 1", Artist = "Artist 1", ImageUrl = "https://via.placeholder.com/150" },
                new { Id = 2, Name = "Album 2", Artist = "Artist 2", ImageUrl = "https://via.placeholder.com/150" }
            };

            return Ok(albums);
        }
    }
}
