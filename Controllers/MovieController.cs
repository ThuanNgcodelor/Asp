using Microsoft.AspNetCore.Mvc;

namespace AnimeAsp.Controllers;

public class MovieController : Controller
{
    public IActionResult Episode(long id)
    {
        return View();
    }

    //Chi tiet Phim
    public IActionResult Details(string title)
    {
        return View();
    }
}