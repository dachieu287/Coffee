using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Coffee.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Coffee.Controllers
{
    public class ShoppingController : Controller
    {
        private readonly CoffeeContext _context;
        public ShoppingController(CoffeeContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Product.ToListAsync());
        }
        public string test()
        {
            return HttpContext.Session.GetString("a");
        }
    }
}