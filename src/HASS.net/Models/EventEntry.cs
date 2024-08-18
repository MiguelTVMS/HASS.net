using System.Text.Json.Serialization;

namespace HASS.net.Models;

public class EventEntry
{
    [JsonPropertyName("event")]
    public string? Event { get; internal set; }

    [JsonPropertyName("listener_count")]
    public int ListenerCount { get; internal set; }
}
