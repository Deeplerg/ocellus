namespace Ocellus;

public static class ShipHelper
{
    private static Dictionary<int, string> coreModuleNames = new()
    {
        { 0, "Power Plant" },
        { 1, "Thrusters" },
        { 2, "Frame Shift Drive" },
        { 3, "Life Support" },
        { 4, "Power Distributor" },
        { 5, "Sensors" },
        { 6, "Fuel Tank" }
    };
    
    public static string ClassToSize(int shipClass)
    {
        return shipClass switch
        {
            1 => "Small",
            2 => "Medium",
            3 => "Large",
            _ => throw new ArgumentException("Unknown ship class value")
        };
    }

    public static string CoreModuleIdToName(int moduleId)
        => coreModuleNames[moduleId];
}