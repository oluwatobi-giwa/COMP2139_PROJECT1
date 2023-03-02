using assignment01_gbcbids.Data;
using assignment01_gbcbids.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace assignment01_gbcbids.Controllers
{
    public class CatalogueController : Controller
    {
        private ApplicationDbContext _context;

        public CatalogueController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        public IActionResult Index()
        {
            var item = _context.Items.ToList();
            var count = _context.Items.Count();
            ViewBag.Count = count;
            return View(item);
        }

        [HttpGet]
        public IActionResult Sort()
        {

            var items = from s in _context.Items select s;
            var Items = _context.Items.OrderByDescending(s => s.itemId).ToList();
            return View(Items);    
        }

        [HttpGet, ActionName("item")]
        public IActionResult Item(int id)
        {
            var item = _context.Items.Find(id);
            return View(item);
        }

        /*[HttpGet]
        public IActionResult Index(string category)
        {
            var items = from s in _context.Items select s;
            var Items = _context.Items.Where(s => s.categoryName.Equals(category)).ToList();
            return View(Items);
        }*/
    }
}
