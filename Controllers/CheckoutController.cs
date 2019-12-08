using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Coffee.Data;
using Microsoft.AspNetCore.Http;
using Coffee.Models;
using Microsoft.EntityFrameworkCore;

namespace Coffee.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly CoffeeContext _context;
        public CheckoutController(CoffeeContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var user = HttpContext.Session.GetString("Id");
            if (String.IsNullOrEmpty(user))
                return View("Empty");

            Account account = await _context.Account.FindAsync(user);

            var cart = from m in _context.Cart
                        select m;
            cart = cart.Where(c => c.User == user);
            List<Cart> carts = await cart.ToListAsync();

            if (carts.Count == 0)
                return View("Empty");

            int price = 0;
            List<Item> items = new List<Item>();
            foreach (Cart item in carts)
            {
                Product product = await _context.Product.FindAsync(item.Product);
                price += product.Price * item.Quantity;
                Item i = new Item();
                i.Name = product.Name;
                i.Quantity = item.Quantity;
                items.Add(i);
            }
            CheckoutView view = new CheckoutView()
            {
                Name = account.Name,
                Address = account.Address,
                Phone = account.Phone,
                Email = account.Email,
                Code = "",
                Note = "",
                Price = price,
                Ship = 15,
                Discount = 0,
                PaymentMethod = 1,
                Items = items
            };           
            return View(view);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout(CheckoutView model)
        {
            if (!ModelState.IsValid)
                return View("Index", model);
            string user = HttpContext.Session.GetString("Id");

            IQueryable<Cart> cart = from m in _context.Cart
                                        select m;
            cart = cart.Where(m => m.User == user);
            List<Cart> carts = await cart.ToListAsync();
            string itemString = "";
            string quantityString = "";
            string priceString = "";
            int total = 0;
            foreach(Cart c in carts)
            {               
                
                Product p = await _context.Product.FindAsync(c.Product);
                itemString += p.Name + ";";
                quantityString += c.Quantity + ";";
                priceString += p.Price + ";";
                total += c.Quantity * p.Price;
            }
            itemString = itemString.TrimEnd(';');
            quantityString = quantityString.TrimEnd(';');
            priceString = priceString.TrimEnd(';');

            string time = String.Format("{0: dd/MM/yyyy hh:mm}", DateTime.Now);

            Bill bill = new Bill()
            {
                User = user,
                Name = model.Name,
                Address = model.Address,
                Phone = model.Phone,
                Email = model.Email,
                Code = model.Code,
                Note = model.Note,
                Items = itemString,
                Quantity = quantityString,
                Price = priceString,
                Discount = 0,
                Ship = 15,
                Total = total + model.Ship - model.Discount,
                PaymentMethod = model.PaymentMethod,
                Time = time,
                Status = 0
            };
            _context.Bill.Add(bill);           
            _context.Cart.RemoveRange(carts);
            await _context.SaveChangesAsync();
            return View();
        }
    }
}