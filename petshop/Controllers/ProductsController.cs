using Microsoft.AspNetCore.Mvc;

namespace petshop.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Product()
        {
            return View();
        }
    }
}
