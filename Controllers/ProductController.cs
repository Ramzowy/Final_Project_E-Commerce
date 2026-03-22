using Microsoft.AspNetCore.Mvc;

namespace Final_Project_E_Commerce.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
