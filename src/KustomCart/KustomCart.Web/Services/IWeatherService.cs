using KustomCart.Shared;

namespace KustomCart.Web.Services
{
    public interface IWeatherService
    {
        Task<IEnumerable<WeatherForecast>> GetWeatherForecastAsync();
    }
}
