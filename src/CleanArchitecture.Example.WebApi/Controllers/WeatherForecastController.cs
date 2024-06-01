using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Example.WebApi.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<string> Get(
            [FromServices] Application.UseCases.Example.UseCase useCase)
        {
            var request = new Application.UseCases.Example.Request
            {
                SomeNumber = 30,
                SomeString = "Hello"
            };

            await useCase.Handle(request);



            return "ok";
        }
    }
}
