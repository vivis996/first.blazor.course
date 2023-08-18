using FirstBlazorApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace FirstBlazorApp.api;

[Route("api/[controller]")]
[ApiController]
public class ForecastController : Controller
{
    // GET: /<controller>/
    public async Task<ActionResult<IEnumerable<WeatherForecast>>> Get()
    {
        var svc = new WeatherForecastService();
        return new OkObjectResult(await svc.GetForecastAsync(DateOnly.FromDateTime(DateTime.Now)));
    }
}
