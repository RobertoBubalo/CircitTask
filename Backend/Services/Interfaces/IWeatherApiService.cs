using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CircitTask.Services.Interfaces
{
    public interface IWeatherApiService
    {
        public Task<T> Get<T>(string endpoint);

    }
}
