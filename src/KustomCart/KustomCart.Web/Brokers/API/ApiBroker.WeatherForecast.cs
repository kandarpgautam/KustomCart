using KustomCart.Shared;

namespace KustomCart.Web.Brokers.API
{
    public partial class ApiBroker
    {
        private const string RelativeUrl = "Api/WeatherForecast/";
        public async ValueTask<WeatherForecast> GetWeatherForecastAsync()
        {
            return await this.ApiClient.GetContentAsync<WeatherForecast>(RelativeUrl);
        }
    }
}
