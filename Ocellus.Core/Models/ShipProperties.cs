using System.Text.Json.Serialization;

namespace Ocellus.Core.Models;

public class ShipProperties
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("manufacturer")]
    public string Manufacturer { get; set; }

    [JsonPropertyName("class")]
    public int Class { get; set; }

    [JsonPropertyName("hullCost")]
    public int HullCost { get; set; }

    [JsonPropertyName("speed")]
    public double Speed { get; set; }

    [JsonPropertyName("boost")]
    public double Boost { get; set; }

    [JsonPropertyName("boostEnergy")]
    public double BoostEnergy { get; set; }

    [JsonPropertyName("heatCapacity")]
    public double HeatCapacity { get; set; }

    [JsonPropertyName("baseShieldStrength")]
    public double BaseShieldStrength { get; set; }

    [JsonPropertyName("baseArmour")]
    public double BaseArmour { get; set; }

    [JsonPropertyName("hardness")]
    public double Hardness { get; set; }

    [JsonPropertyName("hullMass")]
    public double HullMass { get; set; }

    [JsonPropertyName("masslock")]
    public double Masslock { get; set; }

    [JsonPropertyName("pipSpeed")]
    public double PipSpeed { get; set; }

    [JsonPropertyName("pitch")]
    public double Pitch { get; set; }

    [JsonPropertyName("roll")]
    public double Roll { get; set; }

    [JsonPropertyName("yaw")]
    public double Yaw { get; set; }

    [JsonPropertyName("crew")]
    public int Crew { get; set; }

    [JsonPropertyName("reserveFuelCapacity")]
    public double ReserveFuelCapacity { get; set; }
}