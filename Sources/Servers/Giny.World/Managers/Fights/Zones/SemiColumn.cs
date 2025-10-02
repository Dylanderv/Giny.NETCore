using Giny.World.Records.Maps;

namespace Giny.World.Managers.Fights.Zones;

public class SemiColumn : Zone
{
    private IEnumerable<short> Cells
    {
        get;
        set;
    }

    public SemiColumn(IEnumerable<short> cells)
    {
        this.Cells = cells;
    }

    public override CellRecord[] GetCells(CellRecord centerCell, CellRecord casterCell, MapRecord map)
    {
        return Cells.Select(x => map.GetCell(x)).ToArray();
    }
}