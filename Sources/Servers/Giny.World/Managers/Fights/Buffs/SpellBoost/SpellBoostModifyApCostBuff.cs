using Giny.Protocol.Enums;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Buffs.SpellBoost;

public class SpellBoostModifyApCostBuff : SpellBoostBuff
{
    private SpellModifierActionTypeEnum ActionType
    {
        get;
        set;
    }
    public SpellBoostModifyApCostBuff(int id, short spellId, short delta, Fighter target, SpellEffectHandler effectHandler, FightDispellableEnum dispellable, SpellModifierActionTypeEnum modifierAction, short? customActionId = null) : base(id, spellId, delta, target, effectHandler, dispellable, customActionId)
    {
        this.ActionType = modifierAction;
    }
    public override void Execute()
    {
        Target.SpellModifiers.ApplySpellModification(SpellId, SpellModifierTypeEnum.AP_COST, ActionType, (short)GetDelta());
        base.Execute();
    }
    public override void Dispell()
    {
        Target.SpellModifiers.ApplySpellModification(SpellId, SpellModifierTypeEnum.AP_COST, ActionType, (short)-GetDelta());
        base.Dispell();
    }


}