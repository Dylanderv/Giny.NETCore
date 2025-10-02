using Giny.Protocol.Custom.Enums;
using Giny.Protocol.Enums;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Buffs;

public class VitalityBuff : Buff
{
    private short Delta
    {
        get;
        set;
    }
    public VitalityBuff(int id, short delta, Fighter target, SpellEffectHandler effectHandler, FightDispellableEnum dispellable,
        ActionsEnum actionId) :
        base(id, target, effectHandler, dispellable, (short)actionId)
    {
        this.Delta = delta;
    }

    public override void Execute()
    {
        Target.AddMaxVitality(GetDelta());
    }

    public override void Dispell()
    {
        Target.RemoveMaxVitality(GetDelta());
    }

    public override short GetDelta()
    {
        return Math.Abs(Delta);
    }
}