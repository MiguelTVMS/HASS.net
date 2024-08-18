using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HASS.net.Models;

public class HistoryEntry
{
    // root of the json
    public List<EntityHistoryEntry> EntityHistory { get; internal set; } = default!;
}

public class EntityHistoryEntry
{
    //entity_id
    [JsonPropertyName("message")]
    public string EntityId { get; internal set; } = default!;

    //state
    [JsonPropertyName("state")]
    public string State { get; internal set; } = default!;

    //last_changed
    [JsonPropertyName("last_changed")]
    public DateTime LastChanged { get; internal set; } = default!;

    //last_updated
    [JsonPropertyName("last_updated")]
    public DateTime? LastUpdated { get; internal set; }

    //last_reported
    [JsonPropertyName("last_reported")]
    public DateTime? LastReported { get; internal set; }

    //attributes
    [JsonPropertyName("attributes")]
    public Dictionary<string, JsonElement>? Attributes { get; internal set; }

    //context
    [JsonPropertyName("context")]
    public Dictionary<string, JsonElement>? Context { get; internal set; }

}
