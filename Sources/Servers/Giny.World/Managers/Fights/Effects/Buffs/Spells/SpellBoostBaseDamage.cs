using Giny.Protocol.Enums;
using Giny.World.Managers.Effects;
using Giny.World.Managers.Fights.Buffs;
using Giny.World.Managers.Fights.Buffs.SpellBoost;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Effects.Buffs.Spells;

[SpellEffectHandler(EffectsEnum.Effect_SpellBoostBaseDamage)]
public class SpellBoostBaseDamage : SpellEffectHandler
{
       
    public SpellBoostBaseDamage(EffectDice effect, SpellCastHandler castHandler) :
        base(effect, castHandler)
    {

    }

    protected override void Apply(IEnumerable<Fighter> targets)
    {
        short spellId = (short)Effect.Min;
        short delta = (short)Effect.Value;

        foreach (var target in targets)
        {
            Buff buff = new SpellBoostBaseDamageBuff(target.BuffIdProvider.Pop(), spellId, delta, target, this, Effect.DispellableEnum);

            target.AddBuff(buff);
        }
    }

}