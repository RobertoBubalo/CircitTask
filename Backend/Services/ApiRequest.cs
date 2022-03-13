using CircitTask.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CircitTask.Services
{
    public class ApiRequest : IApiRequest
    {
        private readonly HttpClient _httpClient;
        public ApiRequest(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        public async Task<T> Get<T>(string endpoint)
        {
            HttpRequestMessage request = CreateBaseRequest(HttpMethod.Get, endpoint);
            return await this.BaseGet<T>(request);
        }

        public async Task<T> Get<T>(HttpRequestMessage request)
        {
            return await this.BaseGet<T>(request);
        }

        private async Task<T> BaseGet<T>(HttpRequestMessage request)
        {
            HttpResponseMessage response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<T>(json);
                return model;
            }

            // Handle the error gracefully
            string exceptionMsg = await response.Content.ReadAsStringAsync();
            throw new HttpRequestException(exceptionMsg);
        }

        HttpRequestMessage CreateBaseRequest(HttpMethod method, string endpoint)
        {
            return new HttpRequestMessage(method, endpoint);
        }
    }
}
