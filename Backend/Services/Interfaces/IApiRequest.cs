using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CircitTask.Services.Interfaces
{
    public interface IApiRequest
    {
        public Task<T> Get<T>(string endpoint);
        public Task<T> Get<T>(HttpRequestMessage requestMessage);
    }
}
