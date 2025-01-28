using Microsoft.AspNetCore.Mvc;

namespace AnimeAsp.Controllers;

public class BlogController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Detail(long id)
    {
        return View();
    }
}