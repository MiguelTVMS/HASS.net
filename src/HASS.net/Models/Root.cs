using System.Text.Json.Serialization;

namespace HASS.net.Models;

public class Root
{
    [JsonPropertyName("message")]
    public string Message { get; internal set; } = default!;
}
