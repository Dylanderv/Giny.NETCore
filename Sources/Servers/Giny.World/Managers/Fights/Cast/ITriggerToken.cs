using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Cast;

public interface ITriggerToken
{
    Fighter GetSource();
}