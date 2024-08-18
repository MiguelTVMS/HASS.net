using System;
using System.Text.Json.Serialization;

namespace HASS.net.Models;

public class Service
{
    /// <summary>
    /// The name or service.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; internal set; } = default!;

    /// <summary>
    /// The description of the service.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; internal set; }

    /// <summary>
    /// The fields of the service.
    /// </summary>
    [JsonPropertyName("fields")]
    public IDictionary<string, Field>? Fields { get; internal set; }


}
