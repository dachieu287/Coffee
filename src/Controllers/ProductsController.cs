using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Coffee.Data;
using Coffee.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Coffee.Controllers
{
    public class ProductsController : Controller
    {
        private readonly CoffeeContext _context;
     

        public ProductsController(CoffeeContext context)
        {
            _context = context;
            
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            return View(await _context.Product.ToListAsync());
        }
    }
}
