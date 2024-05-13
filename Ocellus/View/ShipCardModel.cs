using Ocellus.Core.Models;

namespace Ocellus.View;

public record class ShipCardModel(
    Ship Ship,
    string ImageFilePath,
    string Url)
{
    public static ShipCardModel FromShip(Ship ship)
    {
        string shipNameKebabCase = ship.Properties.Name.ToKebabCase();
            
        string imageFilename = shipNameKebabCase + ".webp";
        string imageFilePath = Path.Combine("ship-images", imageFilename);
            
        string relativeUrl = Path.Combine("ships", shipNameKebabCase);
            
        return new ShipCardModel(
            Ship: ship,
            ImageFilePath: imageFilePath,
            Url: relativeUrl
        );
    }
}