using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Coffee.Data;
using Coffee.Models;
using Microsoft.EntityFrameworkCore;

namespace Coffee.Controllers
{
    public class AccountController : Controller
    {
        private readonly CoffeeContext _context;
       
        public AccountController(CoffeeContext context)
        {
            _context = context;  
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("Privileze") != 1 && HttpContext.Session.GetInt32("Privileze") != 2)
            {
                return RedirectToAction(nameof(Login));
            }
            else
                return RedirectToAction(nameof(Profile));
        }
        public IActionResult Login()
        {
            if (HttpContext.Session.GetInt32("Privileze") == 1 || HttpContext.Session.GetInt32("Privileze") == 2)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("Id, Password")] Account account)
        {
            if (ModelState.IsValid)
            {
                var loger = await _context.Account.FirstOrDefaultAsync(m => m.Id == account.Id && m.Password == account.Password);
                if (loger != null)
                {
                    HttpContext.Session.SetInt32("Privileze", loger.Privilege);
                    HttpContext.Session.SetString("Id", loger.Id);

                    var cart = from m in _context.Cart
                               where m.User == loger.Id
                               select m;
                    List<Cart> item = await cart.ToListAsync();
                    HttpContext.Session.SetInt32("Cart", item.Count);

                    if (HttpContext.Session.GetInt32("Privileze") == 1)
                        return RedirectToActionPermanentPreserveMethod(actionName: "Product", controllerName: "Admin");
                    else
                        return RedirectToActionPermanentPreserveMethod(actionName: "Index", controllerName: "Home");
                }
                
            }
            ModelState.AddModelError("", "Tài khoản hoặc mật khẩu không chính xác");
            return View(account);
        }

        public IActionResult Signup()
        {
            if (HttpContext.Session.GetInt32("Privileze") != null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Signup([Bind("Id, Password, Repassword, Name, Phone, Email, Address")]CreateAccountView model)
        { 
            if (ModelState.IsValid)
            {
                if (model.Password != model.Repassword)
                {
                    ModelState.AddModelError("Repassword", "Mật khẩu không khớp");
                    return View(model);
                }
                if(_context.Account.Any(key => key.Id == model.Id))
                {
                    ModelState.AddModelError("Id", "Tên tài khoản đã tồn tại");
                    return View(model);
                }
                Account account = new Account();
                account.Id = model.Id; 
                account.Password = model.Password;
                account.Name = model.Name;
                account.Privilege = 2;
                account.Phone = model.Phone;
                account.Email = model.Email;
                account.Address = model.Address;
                _context.Account.Add(account);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Success));
            }
            return View(model);
        }
        public IActionResult Success()
        {
            return View();
        }
        public async Task<IActionResult> Profile()
        {
            var id = HttpContext.Session.GetString("Id");
            if (id == null || id == "")
                return NotFound();
            Account account = await _context.Account.FindAsync(id);
            if(account != null)
            {
                return View(account);
            }
            return NotFound();
        }

        public async Task<IActionResult> EditProfile()
        {
            var id = HttpContext.Session.GetString("Id");
            if (id == null || id == "")
                return NotFound();
            Account account = await _context.Account.FindAsync(id);
            if (account != null)
            {
                return View(account);
            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProfile([Bind("Name, Phone, Email, Address")]Account model)
        {
            if (ModelState.IsValid)
            {
                var id = HttpContext.Session.GetString("Id");
                Account account = await _context.Account.FindAsync(id);
                if (account == null) return NotFound();
                account.Name = model.Name;
                account.Phone = model.Phone;
                account.Email = model.Email;
                account.Address = model.Address;

                try
                {
                     _context.Account.Update(account);
                    await _context.SaveChangesAsync();
                }
                catch(DbUpdateConcurrencyException)
                {
                    if (!_context.Account.Any(a => a.Id == account.Id))
                    {
                        return NotFound();
                    }
                    else
                        throw;
                }
            }
            return RedirectToAction(nameof(Profile));
        }
        public IActionResult ChangePassword()
        {
            if (HttpContext.Session.GetInt32("Privileze") != 1 && HttpContext.Session.GetInt32("Privileze") != 2)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword([Bind("OldPassword, NewPassword, RePassword")] ChangePasswordView model)
        {
            if (ModelState.IsValid)
            {
                if (model.NewPassword != model.RePassword)
                {
                    ModelState.AddModelError("RePassword", "Mật khẩu không khớp");
                    return View(model);
                }
                string id = HttpContext.Session.GetString("Id");
                Account account = await _context.Account.FindAsync(id);
                if (account.Password != model.OldPassword)
                {
                    ModelState.AddModelError("OldPassword", "Không đúng mật khẩu");
                    return View(model);
                }
                account.Password = model.NewPassword;
                try
                {
                    _context.Account.Update(account);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Account.Any(a => a.Id == account.Id))
                    {
                        return NotFound();
                    }
                    else
                        throw;
                }
            }
            else
                return View(model);
            return RedirectToAction(nameof(Profile));
        }
        public IActionResult Logout()
        {
            HttpContext.Session.SetString("Id", "");
            HttpContext.Session.SetInt32("Privileze", 0);
            HttpContext.Session.Clear();

            return RedirectToAction(nameof(Login));
        }

        public async Task<IActionResult> History(int? pageNumber)
        {
            var id = HttpContext.Session.GetString("Id");
            if (id == null || id == "")
                return NotFound();
            var bill = from m in _context.Bill
                       where m.User == id
                       orderby m.Id descending
                       select m;

            int pageSize = 5;
            return View(await PaginatedList<Bill>.CreateAsync(bill, pageNumber ?? 1, pageSize));
        }

        public async Task<IActionResult> DetailsBill(int id)
        {
            var user = HttpContext.Session.GetString("Id");
            if (user == null || user == "")
                return NotFound();
            var bill = await _context.Bill.FindAsync(id);
            if (bill == null)
                return NotFound();

            string[] product = bill.Items.Split(new char[] { ';' });
            string[] quantity = bill.Quantity.Split(new char[] { ';' });
            string[] price = bill.Price.Split(new char[] { ';' });

            List<BillItem> billItems = new List<BillItem>();
            for (int i = 0; i < product.Length; i++)
            {
                BillItem billItem = new BillItem()
                {
                    Name = product[i],
                    Quantity = int.Parse(quantity[i]),
                    Price = int.Parse(price[i])
                };
                billItems.Add(billItem);
            }


            BillView model = new BillView()
            {
                Id = bill.Id,
                User = bill.User,
                Name = bill.Name,
                Phone = bill.Phone,
                Email = bill.Email,
                Address = bill.Address,
                Note = bill.Note,
                Time = bill.Time,
                Code = bill.Code,
                PaymentMethod = bill.PaymentMethod,
                Status = bill.Status,
                Items = billItems,
                Discount = bill.Discount,
                Ship = bill.Ship,
                Total = bill.Total
            };
            return View(model);
        }

        public async Task<IActionResult> CancelBill(int id)
        {
            var user = HttpContext.Session.GetString("Id");
            if (user == null || user == "")
                return NotFound();

            var bill = await _context.Bill.FindAsync(id);
            if (bill == null)
                return NotFound();

            if(bill.Status!=0)
                return NotFound();

            bill.Status = 3;
            _context.Bill.Update(bill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(History));
        }
    }
}