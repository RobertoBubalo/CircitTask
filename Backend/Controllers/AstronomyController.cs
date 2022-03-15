using Backend.Models;
using CircitTask.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CircitTask.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AstronomyController : ControllerBase
    {
        private readonly IWeatherApiService _weatherApiService;

        public AstronomyController(IWeatherApiService weatherApi)
        {
            _weatherApiService = weatherApi;
        }

        [HttpGet]
        public async Task<AstronomyData> GetAsync(string city)
        {
            return await _weatherApiService.Get<AstronomyData>($"astronomy.json?q={city}");
        }
    }
}
