using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace HASS.net.Models;

public class Field
{
    /// <summary>
    /// The selectors are too complex and unstable to be defined in a class.
    /// Maybe in the future we can define them in classes.
    /// TODO: Define the selectors in classes.
    /// <summary>
    /// The selectors are too complex and unstable to be defined in a class.
    /// Maybe in the future we can define them in classes.
    /// TODO: Define the selectors in classes.
    /// </summary>
    [JsonPropertyName("selectors")]
    public JsonNode? Selectors { get; internal set; }
    /// <summary>
    /// The default value of the field. This is a tuple with the value and the type of the value.
    /// The type of the value can be a string, number, boolean, list or and object.
    /// Same as the selectors, the default value is too complex and unstable to be defined in a class.
    /// Maybe in the future we can define them in classes.
    /// TODO: Define the default value in classes.
    /// </summary>
    [JsonPropertyName("default")]
    public JsonNode? Default { get; internal set; }

    /// <summary>
    /// Indicates if the field is required.
    /// </summary>
    [JsonPropertyName("required")]
    public bool? Required { get; internal set; }

    /// <summary>
    /// Indicates if the field is advanced.
    /// </summary>
    [JsonPropertyName("advanced")]
    public bool? Advanced { get; internal set; }

    /// <summary>
    /// The name of the field.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; internal set; }

    /// <summary>
    /// The description of the field.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; internal set; }

    /// <summary>
    /// The example of the field.
    /// The type of the value can be a string, number, boolean, list or and object.
    /// Same as the selectors, the example is too complex and unstable to be defined in a class.
    /// Maybe in the future we can define them in classes.
    /// TODO: Define the example in classes.
    /// </summary>
    [JsonPropertyName("example")]
    public JsonNode? Example { get; internal set; }

    /// <summary>
    /// The filters of the field.
    /// The type of the value can be a string, number, boolean, list or and object.
    /// Same as the selectors, the example is too complex and unstable to be defined in a class.
    /// Maybe in the future we can define them in classes.
    /// TODO: Define the filters in classes.
    /// </summary>
    [JsonPropertyName("filter")]
    public JsonNode? Filter { get; internal set; }
}
