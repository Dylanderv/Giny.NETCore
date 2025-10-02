using Giny.Protocol.Enums;
using Giny.World.Managers.Effects;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Effects.Other;

/*
 * Nothing to do...
 * Spell animations client side
 */
[SpellEffectHandler(EffectsEnum.Effect_NoOperation)]
public class NoOperation : SpellEffectHandler
{
    public NoOperation(EffectDice effect, SpellCastHandler castHandler) : base(effect, castHandler)
    {
    }

    protected override void Apply(IEnumerable<Fighter> targets)
    {
         
    }
}