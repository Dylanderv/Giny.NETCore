using Giny.World.Managers.Criterions.Handlers;
using Giny.World.Managers.Fights.Fighters;
using Giny.World.Network;

namespace Giny.World.Managers.Criterions;

public abstract class Node
{
    public abstract bool Eval(WorldClient client);

    public abstract bool Eval(Fighter fighter);

    public abstract IEnumerable<Criterion> FindCriterionHandlers();

}