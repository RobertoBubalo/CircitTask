using CircitTask.Models;
using CircitTask.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CircitTask.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class testController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherApiService _weatherApiService;

        public testController(ILogger<WeatherForecastController> logger, IWeatherApiService weatherApi)
        {
            _logger = logger;
            _weatherApiService = weatherApi;
        }

        [HttpGet]
        public async Task<Timezone> GetAsync(string city)
        {

            return await _weatherApiService.Get<Timezone>($"timezone.json?q={city}");
        }
    }
}
