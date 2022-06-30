using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(IActionResult index)
        {
            return View(index);
        }

        public IActionResult Error(IActionResult error)
        {
            return View(error);
        }
    }
}
