using Microsoft.AspNetCore.Mvc;

namespace MusicReviewApp.Api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}