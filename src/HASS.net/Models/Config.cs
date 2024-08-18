using System.Text.Json.Serialization;

namespace HASS.net.Models;

public class Config
{
    [JsonPropertyName("latitude")]
    public double Latitude { get; internal set; }

    [JsonPropertyName("longitude")]
    public double Longitude { get; internal set; }

    [JsonPropertyName("elevation")]
    public int Elevation { get; internal set; }

    [JsonPropertyName("unit_system")]
    public UnitSystem? UnitSystem { get; internal set; }

    [JsonPropertyName("location_name")]
    public string? LocationName { get; internal set; }

    [JsonPropertyName("time_zone")]
    public string? TimeZone { get; internal set; }

    [JsonPropertyName("components")]
    public List<string>? Components { get; internal set; }

    [JsonPropertyName("config_dir")]
    public string? ConfigDir { get; internal set; }

    [JsonPropertyName("whitelist_external_dirs")]
    public List<string>? WhitelistExternalDirs { get; internal set; }

    [JsonPropertyName("allowlist_external_dirs")]
    public List<string>? AllowlistExternalDirs { get; internal set; }

    [JsonPropertyName("allowlist_external_urls")]
    public List<object>? AllowlistExternalUrls { get; internal set; }

    [JsonPropertyName("version")]
    public string? Version { get; internal set; }

    [JsonPropertyName("config_source")]
    public string? ConfigSource { get; internal set; }

    [JsonPropertyName("recovery_mode")]
    public bool? RecoveryMode { get; internal set; }

    [JsonPropertyName("state")]
    public string? State { get; internal set; }

    [JsonPropertyName("external_url")]
    public string? ExternalUrl { get; internal set; }

    [JsonPropertyName("internal_url")]
    public string? InternalUrl { get; internal set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; internal set; }

    [JsonPropertyName("country")]
    public string? Country { get; internal set; }

    [JsonPropertyName("language")]
    public string? Language { get; internal set; }

    [JsonPropertyName("safe_mode")]
    public bool? SafeMode { get; internal set; }

    [JsonPropertyName("debug")]
    public bool? Debug { get; internal set; }

    [JsonPropertyName("radius")]
    public int? Radius { get; internal set; }
}
