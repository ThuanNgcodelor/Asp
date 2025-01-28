using Microsoft.AspNetCore.Mvc;

namespace AnimeAsp.Repository.Components;

public class TopViewComponent :ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}