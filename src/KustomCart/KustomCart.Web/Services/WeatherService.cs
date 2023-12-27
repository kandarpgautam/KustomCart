using System.Net.Http.Json;
using KustomCart.Shared;

namespace KustomCart.Web.Services
{
    public class WeatherService : IWeatherService
    {
        public WeatherService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public HttpClient HttpClient { get; }

        public async Task<IEnumerable<WeatherForecast>> GetWeatherForecastAsync()
        {
            return await HttpClient.GetFromJsonAsync<IEnumerable<WeatherForecast>>("WeatherForecast/GetWeatherForecast");
        }
    }
}
