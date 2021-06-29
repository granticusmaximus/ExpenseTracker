using ExpenseTracker.Server.Data;
using ExpenseTracker.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ExpenseTracker.Server.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet("GetItemList")]
        public IActionResult GetItemList()
        {
            IEnumerable<Item> objList = _db.Items;
            return View(objList);
        }


        // POST-Create
        [HttpPost("CreateItem")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item obj)
        {
            _db.Items.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
