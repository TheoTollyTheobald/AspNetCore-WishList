using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WishList.Data;
using WishList.Models;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //DbSet<Item> Items = _context.Items;
            List<Item> Items = _context.Items.ToListAsync();
            return View("Index", Items);
        }

        [HttpGet]public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]public IActionResult Create()
        {

        }
    }
}
