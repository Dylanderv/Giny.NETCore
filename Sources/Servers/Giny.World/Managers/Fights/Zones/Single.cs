using Giny.World.Records.Maps;

namespace Giny.World.Managers.Fights.Zones;

public class Single : Zone
{
    public Single()
    {
    }

    public override CellRecord[] GetCells(CellRecord centerCell, CellRecord casterCell, MapRecord map)
    {
        return new CellRecord[] { centerCell };
    }


}