using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Coffee.Data;
using Coffee.Models;
using Microsoft.EntityFrameworkCore;

namespace Coffee.Controllers
{
    public class CartController : Controller
    {
        private readonly CoffeeContext _context;
        public CartController(CoffeeContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            string user = HttpContext.Session.GetString("Id");

            var model = from m in _context.Cart
                        select m;
            model = model.Where(m => m.User == user);

            List<Cart> carts = await model.ToListAsync();

            List<CartView> cartViews = new List<CartView>();
            foreach (Cart cart in carts)
            {
                Product product = await _context.Product.FindAsync(cart.Product);
                CartView cartView = new CartView();
                cartView.Id = cart.Id;
                cartView.Name = product.Name;
                cartView.Note = product.Note;
                cartView.Image = product.Image;
                cartView.Price = product.Price;
                cartView.Quantity = cart.Quantity;
                cartView.Total = product.Price * cart.Quantity;
                cartViews.Add(cartView);
            }

            return View(cartViews);
        }
        [HttpPost]
        public async Task<string> AddItem(int id)
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("Id")))
            {
                return null;
            }
            
            if (await _context.Cart.AnyAsync(c => c.Product == id))
            {
                return "";
            } 
            Cart cart = new Cart();
            cart.Product = id;
            cart.User = HttpContext.Session.GetString("Id");
            cart.Quantity = 1;
            _context.Cart.Add(cart);
            await _context.SaveChangesAsync();

            var model = from m in _context.Cart
                        select m;
            model = model.Where(m => m.User == HttpContext.Session.GetString("Id"));
            List<Cart> cartArr = await model.ToListAsync();
            return cartArr.Count.ToString();
        }
        [HttpPost]
        public async Task<string> CartQuality()
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("Id")))
            {
                return "0";
            }
            var model = from m in _context.Cart
                        select m;
            model = model.Where(m => m.User == HttpContext.Session.GetString("Id"));
            List<Cart> cart = await model.ToListAsync();
            return cart.Count.ToString();
        }

        

        [HttpPost]
        public async Task<int> ChangeQuantity(int id, int value)
        {
            string user = HttpContext.Session.GetString("Id");

            var model = from m in _context.Cart
                        select m;
            model = model.Where(m => m.User == user);

            List<Cart> carts = await model.ToListAsync();
           
            foreach (Cart cart in carts)
            {
                if (cart.Id == id)
                {
                    cart.Quantity = value;
                    _context.Cart.Update(cart);
                    await _context.SaveChangesAsync();
                }

            }
            return 0;
        }

        public async Task<IActionResult> RemoveItem(int id)
        {
            string user = HttpContext.Session.GetString("Id");

            Cart cart = await _context.Cart.FindAsync(id);

            _context.Cart.Remove(cart);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}