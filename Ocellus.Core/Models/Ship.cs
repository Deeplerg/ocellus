using System.Text.Json.Serialization;

namespace Ocellus.Core.Models;

public class Ship
{
    [JsonPropertyName("properties")]
    public ShipProperties Properties { get; set; }

    [JsonPropertyName("retailCost")]
    public int RetailCost { get; set; }

    [JsonPropertyName("bulkheads")]
    public Bulkhead[] Bulkheads { get; set; }

    [JsonPropertyName("slots")]
    public ShipSlots Slots { get; set; }
}