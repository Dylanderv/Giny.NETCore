using Giny.Protocol.Enums;
using Giny.World.Managers.Effects;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Effects.Movements;

[SpellEffectHandler(EffectsEnum.Effect_Pushback)]
[SpellEffectHandler(EffectsEnum.Effect_Pushback_1103)]
public class Pushback : SpellEffectHandler
{
    public override bool InvertTargetsSort => true;
    public Pushback(EffectDice effect, SpellCastHandler castHandler) : base(effect, castHandler)
    {

    }

    protected override void Apply(IEnumerable<Fighter> targets)
    {
        foreach (var target in targets) 
        {
            target.PushBack(Source, CastCell, (short)Effect.Min, TargetCell);
        }
    }
}