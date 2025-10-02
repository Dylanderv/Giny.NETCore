using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Triggers;

public class Death : ITriggerToken
{
    private Fighter Source
    {
        get;
        set;
    }
    private Fighter Target
    {
        get;
        set;
    }
    public Death(Fighter source, Fighter target)
    {
        this.Source = source;
        this.Target = target;   
    }


    public Fighter GetSource()
    {
        return Source;
    }
}