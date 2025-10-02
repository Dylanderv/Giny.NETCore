using Giny.Protocol.Enums;
using Giny.World.Managers.Effects;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;
using Giny.World.Managers.Fights.Units;

namespace Giny.World.Managers.Fights.Effects.Heals;

[SpellEffectHandler(EffectsEnum.Effect_LifePointsWinBestElement)]
public class LifePointsWinBestElement : SpellEffectHandler
{
    public LifePointsWinBestElement(EffectDice effect, SpellCastHandler castHandler) : base(effect, castHandler)
    {
    }

    protected override void Apply(IEnumerable<Fighter> targets)
    {
        foreach (var target in targets)
        {
            target.Heal(new Healing(Source, target, Source.Stats.GetBestElement(), Effect.Min, Effect.Max, this));
        }
    }
}