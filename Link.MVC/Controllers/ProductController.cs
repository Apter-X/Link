using Microsoft.AspNetCore.Mvc;

namespace Link.MVC.Controllers
{
public class ProductController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
}