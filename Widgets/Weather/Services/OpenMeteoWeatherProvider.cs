using System.Globalization;
using System.Text.Json;
using Weather.Models.Forecast;
using Weather.Models.Geocoding;
namespace Weather.Services;
public class OpenMeteoWeatherProvider
{
    private readonly HttpClient httpClient = new();
    public async Task<ForecastResponse?> GetForecastAsync(double latitude, double longitude, string temperatureUnit)
    {
        try
        {
            var latitudeString = string.Format(CultureInfo.InvariantCulture, "{0:F4}", latitude);
            var longitudeString = string.Format(CultureInfo.InvariantCulture, "{0:F4}", longitude);
            var url = $"https://api.open-meteo.com/v1/forecast?" +
                      $"широта={latitudeString}&" +
                      $"долгота={longitudeString}&" +
                      $"temp_unit={temperatureUnit}&" +
                      $"ток=температура_2м,погодный код,поверхностное_давление&" +
                      $"ежечасно = температура_2 м, код погоды, uv_index, is_day&" +
                      $"ежедневно = температура_2м_мин, температура_2м_макс, код погоды, восход солнца, закат&" +
                      $"часовой пояс = авто";
            var response = await httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode) throw new Exception(JsonSerializer.Serialize(response));
            var json = await response.Content.ReadAsStringAsync();
            var forecast = JsonSerializer.Deserialize<ForecastResponse>(json);
            return forecast;
        }
        catch (Exception e)
        {
            await File.WriteAllTextAsync("weather_crash_log.txt", $"{e.Message}{Environment.NewLine}{e.StackTrace}");
            return null;
        }
    }
    public async Task<AirQualityResponse?> GetAirQualityAsync(double latitude, double longitude)
    {
        try
        {
            var latitudeString = string.Format(CultureInfo.InvariantCulture, "{0:F4}", latitude);
            var longitudeString = string.Format(CultureInfo.InvariantCulture, "{0:F4}", longitude);
            var url = $"https://air-quality-api.open-meteo.com/v1/air-quality?" +
                      $"широта={latitudeString}&" +
                      $"долгота={longitudeString}&" +
                      $"текущий = european_aqi";
            var response = await httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode) throw new Exception(JsonSerializer.Serialize(response));
            var json = await response.Content.ReadAsStringAsync();
            var forecast = JsonSerializer.Deserialize<AirQualityResponse>(json);
            return forecast;
        }
        catch (Exception e)
        {
            await File.WriteAllTextAsync("weather_crash_log.txt", $"{e.Message}{Environment.NewLine}{e.StackTrace}");
            return null;
        }
    }
    public async Task<List<City>?> GetCitiesAsync(string cityName)
    {
        try
        {
            var language = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            var url = $"https://geocoding-api.open-meteo.com/v1/search?" +
                      $"name={cityName}&" +
                      $"язык={language}";
            var response = await httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode) return null;
            var json = await response.Content.ReadAsStringAsync();
            var searchResults = JsonSerializer.Deserialize<GeocodingResponse>(json);
            return searchResults?.Cities;
        }
        catch (Exception e)
        {
            await File.WriteAllTextAsync("weather_crash_log.txt", $"{e.Message}{Environment.NewLine}{e.StackTrace}");
            return null;
        }
    }
}