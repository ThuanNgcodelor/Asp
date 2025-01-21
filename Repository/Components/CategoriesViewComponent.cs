using AnimeAsp.Config;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnimeAsp.Repository.Components;

public class CategoriesViewComponent : ViewComponent
{
    private readonly AppDbContext _dataContext;

    public CategoriesViewComponent(AppDbContext _context)
    {
        _dataContext = _context;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var categories = await _dataContext.Categories.ToListAsync();
        return View(categories);
    }
}