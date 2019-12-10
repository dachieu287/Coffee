using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Coffee.Data;
using Coffee.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Coffee.Controllers
{
    public class AdminController : Controller
    {
        private readonly CoffeeContext _context;
        [Obsolete]
        private readonly IHostingEnvironment _hostingEnvironment;

        [Obsolete]
        public AdminController(CoffeeContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("Privileze") != 1)
            {
                return NotFound();
            }
            return View();
        }
        
        public async Task<IActionResult> Product(
            string searchGenre, 
            string searchString,
            string currentString,
            int? pageNumber)
        {
            if (HttpContext.Session.GetInt32("Privileze") != 1)
                return NotFound();

            ViewData["SearchGenre"] = searchGenre;

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentString;
            }
            ViewData["CurrentString"] = searchString;

            var product = from m in _context.Product
                          select m;
            if (!String.IsNullOrEmpty(searchGenre))
            {
                product = product.Where(s => s.Genre == searchGenre);
            }
            if (!String.IsNullOrEmpty(searchString))
            {
                product = product.Where(s => s.Name.Contains(searchString));
            }

            int pageSize = 3;


            return View(await PaginatedList<Product>.CreateAsync(product, pageNumber ?? 1, pageSize));
        }
        public IActionResult CreateProduct()
        {
            if (HttpContext.Session.GetInt32("Privileze") != 1)
                return NotFound();
            return View(new CreateProductView());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public async Task<IActionResult> CreateProduct(CreateProductView model)
        {
            Product product = new Product();
            if (model.Image != null)
            {
                var uniqueFileName = GetUniqueFileName(model.Image.FileName);
                var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                var filePath = Path.Combine(uploads, uniqueFileName);
                model.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                product.Name = model.Name;
                product.Note = model.Note;
                product.Price = model.Price;
                product.Genre = model.Genre;
                product.Image = uniqueFileName;
            }
            else return View(model);

            if (ModelState.IsValid)
            {
                _context.Product.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Product));
            }
            return View(model);

        }
        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            fileName = fileName.Replace(" ", "-");
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {

            if (HttpContext.Session.GetInt32("Privileze") != 1)
                return NotFound();
            if (id == 0)
            {
                return NotFound();
            }

            var account = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        [HttpPost, ActionName("DeleteProduct")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteProductConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Product));
        }
        // GET: Admin/Details/5
        public async Task<IActionResult> DetailsProduct(int id)
        {
            if (HttpContext.Session.GetInt32("Privileze") != 1)
                return NotFound();
            if (id == 0)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        public async Task<IActionResult> EditProduct(int id)
        {
            if (HttpContext.Session.GetInt32("Privileze") != 1)
                return NotFound();
            if (id == 0)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            CreateProductView model = new CreateProductView()
            {
                Id = product.Id,
                Name = product.Name,
                Genre = product.Genre,
                Price = product.Price,
                Note = product.Note
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public async Task<IActionResult> EditProduct(int id, CreateProductView model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            Product product = new Product();
            if (model.Image != null)
            {
                var uniqueFileName = GetUniqueFileName(model.Image.FileName);
                var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                var filePath = Path.Combine(uploads, uniqueFileName);
                model.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                
                product.Image = uniqueFileName;
            }
            product.Id = model.Id;
            product.Name = model.Name;
            product.Note = model.Note;
            product.Price = model.Price;
            product.Genre = model.Genre;
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Product.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
      
        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.Id == id);
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Privileze");
            HttpContext.Session.Remove("Id");
            HttpContext.Session.Clear();
            return RedirectToActionPermanentPreserveMethod(actionName: "Login", controllerName:"Account");
        }

        public async Task<IActionResult> Account(
            string typeSearch,
            string searchString,
            string currentString,
            int? pageNumber)
        {
            if (HttpContext.Session.GetInt32("Privileze") != 1)
                return NotFound();

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentString;
            }
            ViewData["CurrentString"] = searchString;

            ViewData["TypeSearch"] = typeSearch;


            var account = from m in _context.Account
                          select m;
            account = account.Where(s => s.Id != HttpContext.Session.GetString("Id"));
            if(!String.IsNullOrEmpty(searchString)) 
            switch (typeSearch)
            {
                case "Username":
                    account = account.Where(s => s.Id.Contains(searchString));
                    break;
                case "Name":
                    account = account.Where(s => s.Name.Contains(searchString));
                    break;
                case "Phone":
                    account = account.Where(s => s.Phone.Contains(searchString));
                    break;
                case "Email":
                    account = account.Where(s => s.Email.Contains(searchString));
                    break;
                case "Address":
                    account = account.Where(s => s.Email.Contains(searchString));
                    break;
            }
            int pageSize = 5;
            return View(await PaginatedList<Account>.CreateAsync(account, pageNumber ?? 1, pageSize));
        }

        public async Task<IActionResult> DetailsAccount(string id)
        {
            if (HttpContext.Session.GetInt32("Privileze") != 1)
                return NotFound();
            if (String.IsNullOrEmpty(id))
                return NotFound();
            Account account = await _context.Account.FindAsync(id);
            return View(account);
        }


        public async Task<IActionResult> EditAccount(string id)
        {
            if (HttpContext.Session.GetInt32("Privileze") != 1)
                return NotFound();
            if (String.IsNullOrEmpty(id))
                return NotFound();
            Account account = await _context.Account.FindAsync(id);
            return View(account);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAccount(string id, Account model)
        {
            if(id != model.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Account.Update(model);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Account.Any(a => a.Id == model.Id))
                    {
                        return NotFound();
                    }
                    else throw;
                }
                return RedirectToAction(nameof(Account));
            }
            return View(model);       
        }

        public async Task<IActionResult> DeleteAccount(string id)
        {
            if (HttpContext.Session.GetInt32("Privileze") != 1)
                return NotFound();
            if (String.IsNullOrEmpty(id))
                return NotFound();
            Account account = await _context.Account.FindAsync(id);
            return View(account);
        }

        [HttpPost, ActionName("DeleteAccount")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAccountConfirm(string id)
        {
            Account account = await _context.Account.FindAsync(id);
            _context.Account.Remove(account);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Account));
        }

        public async Task<IActionResult> Bill(
            string typeSearch, 
            string searchString, 
            string status,
            string currentString,
            int? pageNumber)
        {
            if (HttpContext.Session.GetInt32("Privileze") != 1)
                return NotFound();

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentString;
            }
            ViewData["CurrentString"] = searchString;
            ViewData["TypeSearch"] = typeSearch;
            ViewData["Status"] = status;

            var bill = from m in _context.Bill
                       select m;
            
            switch (status)
            {
                case "ChuaXuLi":
                    bill = bill.Where(s => s.Status == 0);
                    break;
                case "DaGiao":
                    bill = bill.Where(s => s.Status == 1);
                    break;
                case "DaHuy":
                    bill = bill.Where(s => s.Status == 3);
                    break;
            }

            if (!String.IsNullOrEmpty(searchString))
            switch (typeSearch)
            {
                case "Id":
                    bill = bill.Where(s => s.Id.ToString().Contains(searchString));
                    break;
                case "User":
                    bill = bill.Where(s => s.User.Contains(searchString));
                    break;
                case "Phone":
                    bill = bill.Where(s => s.Phone.Contains(searchString));
                    break;
                case "Time":
                    bill = bill.Where(s => s.Time.Contains(searchString));
                    break;
            }

            bill = bill.OrderByDescending(s => s.Id);

            int pageSize = 5;
            return View(await PaginatedList<Bill>.CreateAsync(bill, pageNumber ?? 1, pageSize));
        }

        public async Task<IActionResult> DetailsBill(int id)
        {
            if (HttpContext.Session.GetInt32("Privileze") != 1 || id==0)
                return NotFound();
            var bill = await _context.Bill.FindAsync(id);
            if (bill == null)
                return NotFound();

            string[] product = bill.Items.Split(new char[] { ';' });
            string[] quantity = bill.Quantity.Split(new char[] { ';' });
            string[] price = bill.Price.Split(new char[] { ';' });


            List<BillItem> billItems = new List<BillItem>();
            for(int i=0; i<product.Length; i++)
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

        public async Task<IActionResult> EditBill(int id)
        {
            if (HttpContext.Session.GetInt32("Privileze") != 1 || id == 0)
                return NotFound();
            var bill = await _context.Bill.FindAsync(id);
            if (bill == null)
                return NotFound();

            return View(bill);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditBill(int id, Bill model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
                return View(model);

            Bill bill = await _context.Bill.FindAsync(id);
            bill.Name = model.Name;
            bill.Status = model.Status;
            bill.Phone = model.Phone;
            bill.Email = model.Email;
            bill.Address = model.Address;
            bill.Note = model.Note;
            try
            {
                _context.Bill.Update(bill);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Bill.Any(a => a.Id == model.Id))
                {
                    return NotFound();
                }
                else throw;
            }
            return RedirectToAction(nameof(Bill));
        }

        public async Task<IActionResult> BookATable(
            string typeSearch,
            string searchString,
            string currentString,
            int? pageNumber)
        {
            if (HttpContext.Session.GetInt32("Privileze") != 1)
                return NotFound();

            if(searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentString;
            }
            ViewData["CurrentString"] = searchString;
            ViewData["TypeSearch"] = typeSearch;

            var model = from m in _context.BookATable
                        select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                switch (typeSearch)
                {
                    case "Name":
                        model = model.Where(m => (m.FirstName + " " + m.LastName).Contains(searchString));
                        break;
                    case "Phone":
                        model = model.Where(m => m.Phone.Contains(searchString));
                        break;
                    case "Date":
                        model = model.Where(m => m.Date.Contains(searchString));
                        break;
                }
            }
            
            model = model.OrderByDescending(m => m.Id);
            int pageSize =  5;

            return View(await PaginatedList<BookATable>.CreateAsync(model, pageNumber ?? 1, pageSize));
        }

        public async Task<IActionResult> DetailsBookATable(int id)
        {
            if (HttpContext.Session.GetInt32("Privileze") != 1 || id ==0)
                return NotFound();

            var model = await _context.BookATable.FindAsync(id);
            if (model == null)
                return NotFound();

            return View(model);
        }

        public async Task<IActionResult> EditBookATable(int id)
        {
            if (HttpContext.Session.GetInt32("Privileze") != 1 || id == 0)
                return NotFound();

            var model = await _context.BookATable.FindAsync(id);
            if (model == null)
                return NotFound();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditBookATable(int id, BookATable model)
        {
            if(id != model.Id)
            {
                return NotFound();
            }
            _context.BookATable.Update(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(BookATable));
        }

        public async Task<IActionResult> DeleteBookATable(int id)
        {
            if (HttpContext.Session.GetInt32("Privileze") != 1 || id == 0)
                return NotFound();

            var model = await _context.BookATable.FindAsync(id);
            if (model == null)
                return NotFound();
            return View(model);
        }

        [HttpPost]
        [ActionName("DeleteBookATable")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteBookATableConfirm(int id)
        {
            var model = await _context.BookATable.FindAsync(id);
            _context.BookATable.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(BookATable));
        }
    }
}
