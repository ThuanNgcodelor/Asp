using Microsoft.AspNetCore.Mvc;

namespace AnimeAsp.Controllers;

public class CartController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}