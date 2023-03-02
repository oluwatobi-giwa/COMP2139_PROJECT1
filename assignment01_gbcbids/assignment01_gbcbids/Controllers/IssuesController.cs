using Microsoft.AspNetCore.Mvc;

namespace assignment01_gbcbids.Controllers
{
    public class IssuesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Others()
        {
            return View();
        }
    }
}
