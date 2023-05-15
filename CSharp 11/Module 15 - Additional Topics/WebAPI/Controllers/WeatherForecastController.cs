using Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWebHostEnvironment env;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWebHostEnvironment env)
        {
            _logger = logger;
            this.env = env;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public ActionResult<IEnumerable<WeatherForecast>> Get()
        {
            //return BadRequest("Error");
            //HttpContext.Response.Headers.Add("example-header", "The value");

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        public ActionResult<int> Post(WeatherForecast weatherForecast)
        {
            Console.WriteLine(weatherForecast.Summary);
            return 1;
        }

        [HttpGet("uppercase")]
        public ActionResult<string> GetUppercase([FromHeader] string? customValue = "I am Felipe")
        {
            return customValue!.ToUpper();
        }

        [HttpPost("postFile")]
        public async Task<ActionResult> PostFile([FromForm] IFormFile file)
        {
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
            string folder = Path.Combine(env.WebRootPath, "folder");

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            string route = Path.Combine(folder, fileName);

            using (FileStream fs = System.IO.File.Create(route))
            {
                await file.OpenReadStream().CopyToAsync(fs);
            }

            return Ok();
        }

    }
}