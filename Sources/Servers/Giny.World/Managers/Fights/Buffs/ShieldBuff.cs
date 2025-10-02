using Giny.Protocol.Custom.Enums;
using Giny.Protocol.Enums;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Buffs;

public class ShieldBuff : Buff
{
    private const ActionsEnum ActionId = ActionsEnum.ACTION_CHARACTER_BOOST_SHIELD;

    public short Delta
    {
        get;
        set;
    }
    public ShieldBuff(int id, short delta, Fighter target, SpellEffectHandler effectHandler, FightDispellableEnum dispellable) :
        base(id, target, effectHandler, dispellable, (short)ActionId)
    {
        this.Delta = delta;
    }

    public override void Execute()
    {
        Target.AddShield(GetSource(),Delta);
    }

    public override void Dispell()
    {
        Target.RemoveShield(GetSource(),Delta);
    }

    public override string ToString()
    {
        return "Shield " + Delta;
    }
    public override short GetDelta()
    {
        return Delta;
    }
}