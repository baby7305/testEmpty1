using Microsoft.AspNetCore.Mvc;

namespace testEmpty1.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}