using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_based_ticket_management_WebAPI.AppDB;
using Web_based_ticket_management_WebAPI.Model;
using Web_based_ticket_management_WebAPI.Service;

namespace Web_based_ticket_management_WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    //private static readonly string[] Summaries = new[]
    //{
    //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    //};
    private readonly AppDatabaseContex _context;
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, AppDatabaseContex context)
    {
        _logger = logger;
        _context = context;
    }

    //[HttpGet(Name = "GetWeatherForecast")]
    //public IEnumerable<WeatherForecast> Get()
    //{
    //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //{
    //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
    //    TemperatureC = Random.Shared.Next(-20, 55),
    //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //})
    //.ToArray();
    //  }
    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<ActionResult<IEnumerable<TaskTicket>>> Get()
    {
        return await _context.TaskTickets.ToListAsync();
    }
}
