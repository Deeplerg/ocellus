using System.Text.Json.Serialization;

namespace Ocellus.Core.Models;

public class ShipSlots
{
    [JsonPropertyName("standard")]
    public int[] Standard { get; set; }

    [JsonPropertyName("hardpoints")]
    public int[] Hardpoints { get; set; }

    // [JsonPropertyName("internal")]
    // public int[] Internal { get; set; }
}
