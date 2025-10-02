using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Units;

public class Telefrag
{
    public Fighter Source
    {
        get;
        private set;
    }
    public Fighter Target
    {
        get;
        private set;
    }
    public Telefrag(Fighter source, Fighter target)
    {
        Source = source;
        Target = target;
    }
}