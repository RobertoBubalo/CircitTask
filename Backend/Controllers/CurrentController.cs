using Backend.Models;
using CircitTask.Models;
using CircitTask.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
