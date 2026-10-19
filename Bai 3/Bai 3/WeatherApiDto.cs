using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Bai_3;

public class GeocodingResponse
{
    [JsonPropertyName("results")]
    public List<GeocodingResult>? Results { get; set; }
}

public class GeocodingResult
{
    [JsonPropertyName("latitude")]
    public double Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public double Longitude { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}

public class ForecastResponse
{
    [JsonPropertyName("daily")]
    public DailyForecast? Daily { get; set; }
}

public class DailyForecast
{
    [JsonPropertyName("time")]
    public List<string>? Time { get; set; }

    [JsonPropertyName("weather_code")]
    public List<int>? WeatherCode { get; set; }

    [JsonPropertyName("temperature_2m_max")]
    public List<double>? Temperature2mMax { get; set; }

    [JsonPropertyName("temperature_2m_min")]
    public List<double>? Temperature2mMin { get; set; }

    [JsonPropertyName("precipitation_probability_max")]
    public List<int>? PrecipitationProbabilityMax { get; set; }
}
