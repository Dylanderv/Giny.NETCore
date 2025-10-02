using Giny.Protocol.Enums;
using Giny.World.Managers.Effects;
using Giny.World.Managers.Fights.Buffs;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Effects.Debuffs;

[SpellEffectHandler(EffectsEnum.Effect_SubEvadePercent)]
public class StatsDebuffPercent : SpellEffectHandler
{
    public StatsDebuffPercent(EffectDice effect, SpellCastHandler castHandler) : base(effect, castHandler)
    {

    }

    protected override void Apply(IEnumerable<Fighter> targets)
    {
        int delta = Effect.GetDelta();

        foreach (var target in targets)
        {
            int id = target.BuffIdProvider.Pop();

            var characteristic = target.Stats[GetAssociatedCharacteristicEnum()];
            StatPercentBuff statBuff = new StatPercentBuff(id, target, this, Critical, Effect.DispellableEnum, characteristic, (short)-delta, null);
            target.AddBuff(statBuff);
        }
    }
}