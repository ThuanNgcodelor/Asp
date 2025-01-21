using Microsoft.AspNetCore.Mvc;

namespace AnimeAsp.Controllers;

public class MovieController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}