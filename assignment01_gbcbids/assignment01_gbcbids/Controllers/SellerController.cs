using assignment01_gbcbids.Data;
using assignment01_gbcbids.Models;
using assignment01_gbcbids.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace assignment01_gbcbids.Controllers
{
    public class SellerController : Controller
    {
        private ApplicationDbContext _context;
        private readonly IFileService _fileService;
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signinManager;

        public SellerController(ApplicationDbContext context, IFileService fileService, 
            UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signinManager)
        {
            _context = context;
            _fileService = fileService;
            _userManager = userManager;
            _signinManager = signinManager;
        }

        [Authorize(Roles ="seller")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "seller")]
        [ActionName("add-item")]
        public IActionResult AddItem()
        {
            return View();
        }

        [Authorize(Roles = "seller")]
        [ActionName("add-item")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddItem(Item item)
        {
            var imgName = _fileService.SaveImage(item.formFile);
            item.itemImage = imgName;

            _context.Add(item);
            _context.SaveChanges();
            return RedirectToAction("Index", "Seller");
        }

        [Authorize(Roles = "seller")]
        [ActionName("view-items")]

        public IActionResult ViewItems()
        {
            var user = _userManager.GetUserName(HttpContext.User);
            
                var items = from s in _context.Items select s;
                var Items = _context.Items.Where(s => s.SellerEmail.Equals(user)).ToList();
                return View(Items);
        }

        [Authorize(Roles = "seller")]
        [HttpGet, ActionName("edit-item")]
        public IActionResult EditItem(int id)
        {
            var item = _context.Items.Find(id);
            /*var imgName = _fileService.SaveImage(item.formFile);
            item.itemImage = imgName;*/
            return View(item);
        }

        [Authorize(Roles = "seller")]
        [HttpPost, ActionName("edit-item")]
        [ValidateAntiForgeryToken]

        public IActionResult EditItem(Item item)
        {
            if (item.formFile != null)
            {
                var imgName = _fileService.SaveImage(item.formFile);
                item.itemImage = imgName; 
            }


            if (item.itemId != 0)
            {
                _context.Items.Update(item);
                _context.SaveChanges();
            }
            
            return RedirectToAction("view-items", "Seller");
        }


        [Authorize(Roles = "seller")]
        [HttpGet, ActionName("delete-item")]
        public IActionResult DeleteItem(int id)
        {
            var item = _context.Items.Find(id);
            return View(item);
        }


        [Authorize(Roles = "seller")]
        [HttpPost, ActionName("delete-item")]
        public IActionResult DeleteItem(Item item) {
            _context.Items.Remove(item);
            _context.SaveChanges();
            return RedirectToAction("view-items", "Seller");
        }

        /* [Authorize(Roles = "seller")]
         [HttpPost, ActionName("edit-item")]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> EditItem(ItemViewModel itemViewModel)
         {
             var item = await _context.Items.FindAsync(itemViewModel.itemId);
             var imgName = _fileService.SaveImage(item.formFile);
             if (item != null)
             {
                 item.itemDesc= itemViewModel.itemDesc;
                 item.itemCost= itemViewModel.itemCost; 
                 item.startDate= itemViewModel.startDate; 
                 item.endDate= itemViewModel.endDate;
                 item.itemCondition = itemViewModel.itemCondition;
                 item.SellerEmail = itemViewModel.SellerEmail;
                 item.categoryName = itemViewModel.categoryName;
                 item.itemImage = imgName;

                 await _context.SaveChangesAsync();
                 return RedirectToAction("Index");
             }
             return RedirectToAction("Index");
         }


         [Authorize(Roles = "seller")]
         [HttpGet, ActionName("delete-item")]
         public IActionResult DeleteItem(int id)
         {
             //var item =  new Item();
             var item = _context.Items.FirstOrDefault(x => x.itemId == id);
             return View(item);
         }






         [Authorize(Roles = "seller")]
         [HttpPost, ActionName("delete-item")]
         [ValidateAntiForgeryToken]
         public IActionResult DeleteItem(Item item)
         {
             *//*if (!ModelState.IsValid)
             {
                 return View(item);
             }*//*


             _context.Items.Remove(item);
             _context.SaveChanges();
             return RedirectToAction("view-items", "Seller");
         }*/

        /*[Authorize(Roles = "seller")]
        [HttpPost, ActionName("edit-item")]
        [ValidateAntiForgeryToken]
        public IActionResult EditItem(Item item)
        {
            *//*if (!ModelState.IsValid)
            {
                return View(item);
            }*//*

            var imgName = _fileService.SaveImage(item.formFile);
            item.itemImage = imgName;
            _context.Items.Update(item);
            _context.SaveChanges();
            return RedirectToAction("view-items", "Seller");
        }*/

        /*[Authorize(Roles = "seller")]
        [HttpGet, ActionName("edit-item")]
        public IActionResult Edit(int id)
        {
            var item = new Item();
            return View(item);
        }

        [Authorize(Roles = "seller")]
        [HttpPost, ActionName("edit-item")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditItem(int id, [Bind("itemId,itemDesc, itemCost, startDate, endDate, itemCondition, sellerEmail, categoryName, itemImage")] Item item)
        {
            if (id != item.itemId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _context.Update(item);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }*/



        /*[Authorize(Roles = "seller")]
         [ActionName("edit-item")]*/
        /*[HttpGet]
        public IActionResult EditItem(int itemId)
        {
            var findItem = _context.Items.Find(itemId);
            return View(findItem);
        }

        [Authorize(Roles = "seller")]
        *//*[ActionName("edit-item")]*//*
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditItem(Item item)
        {
            if (!ModelState.IsValid)
            {
                return View(item);
            }
            
            var imgName = _fileService.SaveImage(item.formFile);
            item.itemImage = imgName;
            _context.Items.Update(item);
            _context.SaveChanges();
            return RedirectToAction("view-items", "Seller");
        }*/


        /*[HttpGet]
        public IActionResult DeleteItem(int id)
        {
            Item item = new Item();
            if (!ModelState.IsValid)
            {
                return View(item);
            }

            var imgName = _fileService.SaveImage(item.formFile);
            var delItem = _context.Items.Find(id);

            if (delItem != null)
            {
                _context.Remove(delItem);
                _context.SaveChanges();
                return RedirectToAction("ViewItems", "Seller");
            } else
            {
                return View(item);
            }
        }*/

    }
}


