using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Effects.Targets;

public class TelefragCriterion : TargetCriterion
{
    public override bool RefreshTargets => true;

    public override bool IsTargetValid(Fighter actor, SpellEffectHandler handler) => handler.CastHandler.IsTelefraged(actor);

    public override string ToString()
    {
        return "Telefrag";
    }
}