using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace HASS.net.Models;

public class ServiceEntry
{
    [JsonPropertyName("domain")]
    public string Domain { get; internal set; } = default!;

    [JsonPropertyName("services")]
    public IDictionary<string, Service> Services { get; internal set; } = default!;

}
