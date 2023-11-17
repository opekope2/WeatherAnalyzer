using WeatherAnalyzer.Geocode;

namespace WeatherAnalyzer.Weather.Api;

public interface IWeatherForecastApi
{
    IAsyncEnumerable<WeatherForecast> GetWeatherForecastsAsync(Location location);
}
