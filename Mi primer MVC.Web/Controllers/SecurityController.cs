using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mi_primer_MVC.Web.Controllers
{
    public class SecurityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string email,string password) 
        {

            if (email == "mezajose@gmail.com" && password == "1234")
            {
                return RedirectToAction("Index", "Home", new { area = "Marketing"});
            }

            return RedirectToAction("Index");
        }
    }
}
