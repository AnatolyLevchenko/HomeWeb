using Microsoft.AspNetCore.Mvc;

namespace HomeWeb.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "Weather data" };
    }
}