using Giny.Protocol.Enums;
using Giny.World.Managers.Effects;
using Giny.World.Managers.Fights.Buffs;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Effects.Buffs;

[SpellEffectHandler(EffectsEnum.Effect_SkipTurn)]
public class SkipTurn : SpellEffectHandler
{
    public SkipTurn(EffectDice effect, SpellCastHandler castHandler) :
        base(effect, castHandler)
    {

    }

    protected override void Apply(IEnumerable<Fighter> targets)
    {
        foreach (var target in targets)
        {
            SkipTurnBuff buff = new SkipTurnBuff(target.BuffIdProvider.Pop(), target, this, Effect.DispellableEnum);
            target.AddBuff(buff);
        }
    }

}