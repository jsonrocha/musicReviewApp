
using Microsoft.AspNetCore.Mvc;

namespace MusicReviewApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
