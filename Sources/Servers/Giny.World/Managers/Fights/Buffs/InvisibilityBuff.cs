using Giny.Protocol.Enums;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Buffs;

public class InvisibilityBuff : Buff
{
    public InvisibilityBuff(int id, Fighter target, SpellEffectHandler effectHandler, FightDispellableEnum dispellable, short? customActionId = null) : base(id, target, effectHandler, dispellable, customActionId)
    {
    }

    public override void Execute()
    {
        Target.SetInvisiblityState(GameActionFightInvisibilityStateEnum.INVISIBLE, Cast.Source);
    }

    public override void Dispell()
    {
        Target.SetInvisiblityState(GameActionFightInvisibilityStateEnum.VISIBLE, Cast.Source);
    }

    public override short GetDelta()
    {
        return 0;
    }
}