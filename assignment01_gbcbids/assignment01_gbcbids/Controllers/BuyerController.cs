using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace assignment01_gbcbids.Controllers
{
    public class BuyerController : Controller
    {
        [Authorize(Roles = "buyer")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
