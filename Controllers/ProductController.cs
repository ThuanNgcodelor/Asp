using Microsoft.AspNetCore.Mvc;

namespace AnimeAsp.Controllers;

public class ProductController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}