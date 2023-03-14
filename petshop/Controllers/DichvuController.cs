using Microsoft.AspNetCore.Mvc;

namespace petshop.Controllers
{
    public class DichvuController : Controller
    {
        public IActionResult Dichvu()
        {
            return View();
        }
    }
}
