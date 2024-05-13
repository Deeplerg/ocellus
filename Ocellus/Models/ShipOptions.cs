using Ocellus.Core.Models;

namespace Ocellus.Models;

public class ShipOptions
{
    public const string Position = "ships";

    public List<Ship> Ships { get; set; } = new();
}