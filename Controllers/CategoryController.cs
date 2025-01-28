using AnimeAsp.Config;
using AnimeAsp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnimeAsp.Controllers;

public class CategoryController : Controller
{
    private readonly AppDbContext _context;

    public CategoryController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index(string? categoryName)
    {
        if (string.IsNullOrEmpty(categoryName))
        {
            // Redirect to home if no categoryName is provided
            return RedirectToAction("Index", "Home");
        }

        // Find the category based on the category name
        var category = await _context.Categories
            .FirstOrDefaultAsync(c => c.CategoryName == categoryName);

        if (category == null)
        {
            return RedirectToAction("Index", "Home");
        }

        // Fetch movies associated with the category
        var moviesByCategory = await _context.Movies
            .Where(m => m.Categories.Any(c => c.CategoryName == category.CategoryName))
            .ToListAsync();
        

        // Pass the list of movies to the view
        return View(moviesByCategory);
    }
}