using Giny.Protocol.Enums;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Buffs.SpellBoost;

public class SpellBoostRemoveLOSBuff : SpellBoostBuff
{
    public SpellBoostRemoveLOSBuff(int id, short spellId, short delta, Fighter target, SpellEffectHandler effectHandler, FightDispellableEnum dispellable, short? customActionId = null) : base(id, spellId, delta, target, effectHandler, dispellable, customActionId)
    {
    }

    public override void Execute()
    {
        Target.SpellModifiers.ApplySpellModification(SpellId, SpellModifierTypeEnum.LOS, SpellModifierActionTypeEnum.ACTION_SET, 0);
        base.Execute();
    }
    public override void Dispell()
    {
        Target.SpellModifiers.ApplySpellModification(SpellId, SpellModifierTypeEnum.LOS, SpellModifierActionTypeEnum.ACTION_SET, 1);
        base.Dispell();
    }
}