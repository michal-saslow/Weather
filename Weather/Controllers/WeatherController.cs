
using Weather.Core.Sevice;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Weather.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        // GET api/<CustomerController>/5
        [HttpGet("{city}")]
        public string Get(String city)
        {

            return $"the weatehr in{city} is: {_weatherService.GetTemp(city).GetAwaiter().GetResult() } condition { _weatherService.GetCondition(city).GetAwaiter().GetResult()}";
        }
        [HttpGet("getAll/{city}")]
        public Task<string> GetAll(String city)
        {
            return _weatherService.GetJsonDataFromUrl(city);
        }


    }
}
