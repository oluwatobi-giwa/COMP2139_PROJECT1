using assignment01_gbcbids.Data;
using Microsoft.AspNetCore.Mvc;

namespace assignment01_gbcbids.Controllers
{
    public class SearchController : Controller
    {
        private ApplicationDbContext _context;

        public SearchController(ApplicationDbContext context)
        {
            _context = context;
        }
       

        
  
    
        public IActionResult Index(string searchString)
        {
            var items = from s in _context.Items select s;
            var Items = _context.Items.Where(s => s.itemName.Equals(searchString)).ToList();
            return View(Items);
        }
    }
}
