using Giny.Core.DesignPattern;
using Giny.World.Records.Maps;
using System.Drawing;

namespace Giny.World.Managers.Formulas;

public class TeleporterFormulas : Singleton<TeleporterFormulas>
{
    public const short ZAAPI_COST = 20;

    public short GetZaapCost(MapRecord zaapMap, MapRecord currentMap)
    {
        Point position = currentMap.Position.Point;
        Point position2 = zaapMap.Position.Point;
        return (short)Math.Floor(Math.Sqrt(((position2.X - position.X) * (position2.X - position.X) + (position2.Y - position.Y) * (position2.Y - position.Y))) * 10.0);
    }
}