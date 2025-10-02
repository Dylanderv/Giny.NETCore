using Giny.Protocol.Enums;
using Giny.World.Managers.Effects;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;
using Giny.World.Records.Spells;

namespace Giny.World.Managers.Fights.Effects.Summons;

[SpellEffectHandler(EffectsEnum.Effect_ReviveAndGiveHPToLastDiedAlly)]
public class ReviveAndGiveHp : SpellEffectHandler
{
    private const short ZombieStateId = 74;

    public ReviveAndGiveHp(EffectDice effect, SpellCastHandler castHandler) : base(effect, castHandler)
    {
    }

    protected override void Apply(IEnumerable<Fighter> targets)
    {
        var target = Source.Team.GetLastDeadFighter();

        if (target != null && Source.Fight.IsCellFree(TargetCell))
        {
            int lifePercent = Effect.Min;

            target.Revive(Source, TargetCell, lifePercent);

            AddStateBuff(target, SpellStateRecord.GetSpellStateRecord(ZombieStateId)!, FightDispellableEnum.REALLY_NOT_DISPELLABLE);
        }
    }


}