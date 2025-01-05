using Microsoft.AspNetCore.Mvc;

namespace MusicReviewApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlbumsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAlbums()
        {
            var albums = new[]
            {
                new { Id = 1, Name = "Album 1", Artist = "Artist 1", ReleaseDate = "2025-01-01", ImageUrl = "https://via.placeholder.com/150" },
                new { Id = 2, Name = "Album 2", Artist = "Artist 2", ReleaseDate = "2024-12-15", ImageUrl = "https://via.placeholder.com/150" }
            };

            return Ok(albums);
        }

        [HttpGet("{id}")]
        public IActionResult GetAlbum(int id)
        {
            // Mock album data
            var album = new
            {
                Id = id,
                Name = "Album 1",
                Artist = "Artist 1",
                ReleaseDate = "2025-01-01",
                ImageUrl = "https://via.placeholder.com/150",
                Tracks = new[] { "Track 1", "Track 2", "Track 3" }
            };

            return Ok(album);
        }

        [HttpPost]
        public IActionResult AddAlbum([FromBody] dynamic album)
        {
            // Example logic to save the album (you'll replace this with real DB logic)
            return CreatedAtAction(nameof(GetAlbum), new { id = 3 }, album);
        }
    }
}
