using CircitTask.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CircitTask.Services
{
    public class WeatherApiService : IWeatherApiService
    {
        private readonly string _baseEndpoint = "https://api.exchangerate.host/latest";
        private readonly string _key;
        private readonly string _host;
        private readonly IApiRequest _apiRequest;

        public WeatherApiService(IApiRequest apiRequest, IConfiguration config)
        {
            _apiRequest = apiRequest;
            var weatherSection = config.GetSection("ExternalApi").GetSection("Weather");
            _baseEndpoint = weatherSection.GetSection("Url").Value;
            _key = weatherSection.GetSection("Key").Value;
            _host = weatherSection.GetSection("Host").Value;
        }

        public async Task<T> Get<T>(string endpoint)
        {
            return await _apiRequest.Get<T>(
                CreateBaseRequest(
                    HttpMethod.Get,
                    endpoint
                ));

            var qParams = CreateQueryParams();
            //return await _apiRequest.Get<T>(endpoint);
        }

        HttpRequestMessage CreateBaseRequest(HttpMethod method, string endpoint, string queryParams = "")
        {
            return new HttpRequestMessage
            {
                Method = method,
                RequestUri = new Uri($"{_baseEndpoint}{endpoint}{(string.IsNullOrEmpty(queryParams) ? "" : "/?" + queryParams )}"),
                //RequestUri = new Uri($"https://weatherapi-com.p.rapidapi.com/timezone.json?q={city}"),
                Headers =
                {
                    { "x-rapidapi-host", _host },
                    { "x-rapidapi-key", _key },
                },
            };
        }

        private string CreateQueryParams()
        {


            return "";
        }
    }
}
