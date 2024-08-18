using System.Text.Json.Serialization;

namespace HASS.net.Models;

public partial class StateChangeEntry
{
    [JsonPropertyName("attributes")]
    public Dictionary<string, string>? Attributes { get; internal set; }

    [JsonPropertyName("entity_id")]
    public string? EntityId { get; internal set; }

    [JsonPropertyName("last_changed")]
    public DateTime LastChanged { get; internal set; } = default!;

    [JsonPropertyName("last_updated")]
    public DateTime? LastUpdated { get; internal set; }

    [JsonPropertyName("state")]
    public string State { get; internal set; } = default!;
}


