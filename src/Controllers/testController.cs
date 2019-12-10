using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;

namespace Coffee.Controllers
{
    public class testController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("a",  "aaa");
            return RedirectToActionPermanentPreserveMethod(actionName: "Test", controllerName: "Shopping");
            
        }
        public string Test()
        {
            
            var a = HttpContext.Session.GetString("a");
            return a;
        }
    }
}