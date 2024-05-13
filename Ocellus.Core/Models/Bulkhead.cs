using System.Text.Json.Serialization;

namespace Ocellus.Core.Models;

public class Bulkhead
{
    [JsonPropertyName("cost")]
    public int Cost { get; set; }

    [JsonPropertyName("mass")]
    public double Mass { get; set; }

    [JsonPropertyName("causticResistance")]
    public double CausticResistance { get; set; }

    [JsonPropertyName("explosiveResistance")]
    public double ExplosiveResistance { get; set; }

    [JsonPropertyName("kineticResistance")]
    public double KineticResistance { get; set; }

    [JsonPropertyName("thermalResistance")]
    public double ThermalResistance { get; set; }

    [JsonPropertyName("hullBoost")]
    public double HullBoost { get; set; }
}