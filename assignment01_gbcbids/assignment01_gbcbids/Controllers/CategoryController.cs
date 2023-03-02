using assignment01_gbcbids.Data;
using assignment01_gbcbids.Models;
using Microsoft.AspNetCore.Mvc;

namespace assignment01_gbcbids.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public int countItems(string categoryName)
        {
            var count = _context.Items.Where(s => s.categoryName.Equals(categoryName)).Count();
            return count;
        }

        public IActionResult Artillery()
        {
            var items = from s in _context.Items select s;
            var Items = _context.Items.Where(s => s.categoryName.Equals("Artillery")).ToList();
            ViewBag.Count = countItems("Artillery");

            return View(Items);
        }

        public IActionResult Artifacts()
        {
            var items = from s in _context.Items select s;
            var Items = _context.Items.Where(s => s.categoryName.Equals("Artifacts")).ToList();
            ViewBag.Count = countItems("Artifacts");

            if (items == null)
            {
                ViewBag.Msg = "No item here";
            }

            return View(Items);
        }

        public IActionResult Books()
        {
            var items = from s in _context.Items select s;
            var Items = _context.Items.Where(s => s.categoryName.Equals("Books")).ToList();
            ViewBag.Count = countItems("Books");

            if (items == null)
            {
                ViewBag.Msg = "No item here";
            }

            return View(Items);
        }

        public IActionResult Cars()
        {
            var items = from s in _context.Items select s;
            var Items = _context.Items.Where(s => s.categoryName.Equals("Cars")).ToList();
            ViewBag.Count = countItems("Cars");

            if (items == null)
            {
                ViewBag.Msg = "No item here";
            }

            return View(Items);
        }

        public IActionResult Furnitures()
        {
            var items = from s in _context.Items select s;
            var Items = _context.Items.Where(s => s.categoryName.Equals("Furnitures")).ToList();
            ViewBag.Count = countItems("Furnitures");

            if (items == null)
            {
                ViewBag.Msg = "No item here";
            }

            return View(Items);
        }

        public IActionResult Jewelries()
        {
            var items = from s in _context.Items select s;
            var Items = _context.Items.Where(s => s.categoryName.Equals("Jewelries")).ToList();
            ViewBag.Count = countItems("Jewelries");

            if (items == null)
            {
                ViewBag.Msg = "No item here";
            }

            return View(Items);
        }

    }
}
