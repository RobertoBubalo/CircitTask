using Backend.Models;
using CircitTask.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CircitTask.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CurrentController : ControllerBase
    {
        private readonly IWeatherApiService _weatherApiService;

        public CurrentController(IWeatherApiService weatherApi)
        {
            _weatherApiService = weatherApi;
        }

        [HttpGet]
        public async Task<CurrentData> GetAsync(string city)
        {
            return await _weatherApiService.Get<CurrentData>($"current.json?q={city}");
        }
    }
}
