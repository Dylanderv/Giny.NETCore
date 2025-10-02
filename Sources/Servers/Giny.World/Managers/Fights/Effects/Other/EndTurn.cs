using Giny.Protocol.Enums;
using Giny.World.Managers.Effects;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Effects.Other;

[SpellEffectHandler(EffectsEnum.Effect_EndTurn)]
public class EndTurn : SpellEffectHandler
{
    public EndTurn(EffectDice effect, SpellCastHandler castHandler) : base(effect, castHandler)
    {
    }

    protected override void Apply(IEnumerable<Fighter> targets)
    {
        var target = targets.FirstOrDefault();

        if (!target.IsFighterTurn)
        {
            return;
        }

        CastHandler.Cast.PassTurn = true;
    }
}