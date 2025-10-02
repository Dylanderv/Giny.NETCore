using Giny.World.Records.Maps;

namespace Giny.World.Managers.Fights.History;

public class MovementHistoryEntry
{
    public MovementHistoryEntry(CellRecord cell, int currentRound)
    {
        Cell = cell;
        Round = currentRound;
    }

    public CellRecord Cell
    {
        get;
        private set;
    }

    public int Round
    {
        get;
        private set;
    }
}