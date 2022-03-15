using CircitTask.Models;
using CircitTask.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CircitTask.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TimeZoneController : ControllerBase
    {
        private readonly IWeatherApiService _weatherApiService;

        public TimeZoneController(IWeatherApiService weatherApi)
        {
            _weatherApiService = weatherApi;
        }

        [HttpGet]
        public async Task<Timezone> GetAsync(string city)
        {
            return await _weatherApiService.Get<Timezone>($"timezone.json?q={city}");
        }
    }
}
