using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mi_primer_MVC.Web.Areas.Marketing.Controllers
{
    public class HomeController : Controller
    {   
        [Area("Marketing")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
