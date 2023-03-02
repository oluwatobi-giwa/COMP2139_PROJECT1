using assignment01_gbcbids.Data;
using assignment01_gbcbids.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;

namespace assignment01_gbcbids.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
           
            return View();
        }


        public IActionResult Search(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;


            var items = from s in _context.Items select s;
            
          


            if (!String.IsNullOrEmpty(searchString))
            {

                var item = _context.Items.Where(s => s.itemName.Contains(searchString)
                                       || s.categoryName.Contains(searchString)).ToList();
                return View(item);
            }

            return View(_context.Items);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}