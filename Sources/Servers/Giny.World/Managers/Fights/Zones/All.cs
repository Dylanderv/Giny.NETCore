using Giny.World.Records.Maps;

namespace Giny.World.Managers.Fights.Zones;

public class All : Zone
{
    public All()
    {

    }

    public override CellRecord[] GetCells(CellRecord centerCell, CellRecord casterCell, MapRecord map)
    {
        return map.Cells.Where(x => x.IsValidFightCell()).ToArray();
    }
}