using System.Threading.Tasks;

namespace CircitTask.Services.Interfaces
{
    public interface IWeatherApiService
    {
        public Task<T> Get<T>(string endpoint);

    }
}
