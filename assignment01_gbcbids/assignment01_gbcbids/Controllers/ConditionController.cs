using assignment01_gbcbids.Data;
using assignment01_gbcbids.Models;
using Microsoft.AspNetCore.Mvc;

namespace assignment01_gbcbids.Controllers
{
    public class ConditionController : Controller
    {
        private ApplicationDbContext _context;

        public ConditionController(ApplicationDbContext context)
        {
            _context = context;
        }

        public int countItems(string conditionName)
        {
            var count = _context.Items.Where(s => s.itemCondition.Equals(conditionName)).Count();
            return count;
        }

        
        public IActionResult New()
        {
            var items = from s in _context.Items select s;
            var Items = _context.Items.Where(s => s.itemCondition.Equals("New")).ToList();
            ViewBag.Count = countItems("New");

            return View(Items);
        }


        [ActionName("open-box")]

        public IActionResult OpenBox()
        {
            var items = from s in _context.Items select s;
            var Items = _context.Items.Where(s => s.itemCondition.Equals("Open Box")).ToList();
            ViewBag.Count = countItems("open Box");

            if (items == null)
            {
                ViewBag.Msg = "No item here";
            }

            return View(Items);
        }

        [ActionName("fairly-used")]
        public IActionResult FairlyUsed()
        {
            var items = from s in _context.Items select s;
            var Items = _context.Items.Where(s => s.itemCondition.Equals("Fairly Used")).ToList();
            ViewBag.Count = countItems("open Box");

            if (items == null)
            {
                ViewBag.Msg = "No item here";
            }

            return View(Items);
        }

        
        public IActionResult Refurbished()
        {
            var items = from s in _context.Items select s;
            var Items = _context.Items.Where(s => s.itemCondition.Equals("Refurbished")).ToList();
            ViewBag.Count = countItems("open Box");

            if (items == null)
            {
                ViewBag.Msg = "No item here";
            }

            return View(Items);
        }

    }
}
