using System.Diagnostics;
using Final_Project_E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project_E_Commerce.Controllers
{
    public class HomeController : Controller
    {
   

        public IActionResult Index()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
