using Mi_primer_MVC.Web.Areas.Marketing.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Mi_primer_MVC.Web.Areas.Marketing.Controllers
{
    [Area("Marketing")]
    public class HomeController : Controller
    {   
        public IActionResult Index()
        {
            return View();
        }




        public IEnumerable<Product> GetJsonProducts() {

            var folder = Path.Combine(Directory.GetCurrentDirectory(), "Areas\\Marketing\\Data\products.json");

            var Json = System.IO.File.ReadAllText(folder);

            var products = JsonConvert.DeserializeObject<IEnumerable<Product>>(Json);

            return products;
        
        }
    }
}
