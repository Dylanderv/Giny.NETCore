using Giny.Protocol.Enums;
using Giny.World.Managers.Effects;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Effects.Movements;

[SpellEffectHandler(EffectsEnum.Effect_Advance)]
public class Advance : SpellEffectHandler
{
    public Advance(EffectDice effect, SpellCastHandler castHandler) : base(effect, castHandler)
    {
    }

    protected override void Apply(IEnumerable<Fighter> targets)
    {
        foreach (var target in targets)
        {
            if (Source.Cell != target.Cell)
            {
                Source.Advance(Source, (short)Effect.Min, target.Cell);
            }
        }
            
    }
}