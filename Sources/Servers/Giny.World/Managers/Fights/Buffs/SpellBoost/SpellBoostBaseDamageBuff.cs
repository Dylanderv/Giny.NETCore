using Giny.Protocol.Enums;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Buffs.SpellBoost;

public class SpellBoostBaseDamageBuff : SpellBoostBuff
{
    public SpellBoostBaseDamageBuff(int id, short spellId, short delta, Fighter target, SpellEffectHandler effectHandler, FightDispellableEnum dispellable, short? customActionId = null) : base(id, spellId, delta, target, effectHandler, dispellable, customActionId)
    {
    }

    public override void Execute()
    {
        Target.SpellModifiers.ApplySpellModification(SpellId,
            SpellModifierTypeEnum.BASE_DAMAGE, SpellModifierActionTypeEnum.ACTION_BOOST, GetDelta());

        base.Execute();
    }
    public override void Dispell()
    {
        Target.SpellModifiers.ApplySpellModification(SpellId,
            SpellModifierTypeEnum.BASE_DAMAGE, SpellModifierActionTypeEnum.ACTION_BOOST, (short)-GetDelta());

        base.Dispell();
    }
    public override string ToString()
    {
        return $"SpellBoost (BaseDamages) {base.Cast.Spell.Record.Name} +{GetDelta()}";
    }


}