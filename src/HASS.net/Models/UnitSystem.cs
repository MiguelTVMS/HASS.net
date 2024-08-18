using System.Text.Json.Serialization;

namespace HASS.net.Models;

public class UnitSystem
{
    [JsonPropertyName("length")]
    public string? Length { get; internal set; }

    [JsonPropertyName("accumulated_precipitation")]
    public string? AccumulatedPrecipitation { get; internal set; }

    [JsonPropertyName("mass")]
    public string? Mass { get; internal set; }

    [JsonPropertyName("pressure")]
    public string? Pressure { get; internal set; }

    [JsonPropertyName("temperature")]
    public string? Temperature { get; internal set; }

    [JsonPropertyName("volume")]
    public string? Volume { get; internal set; }

    [JsonPropertyName("wind_speed")]
    public string? WindSpeed { get; internal set; }
}
