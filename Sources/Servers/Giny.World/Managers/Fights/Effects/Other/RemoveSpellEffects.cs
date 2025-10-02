using Giny.Protocol.Enums;
using Giny.World.Managers.Effects;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Effects.Other;

[SpellEffectHandler(EffectsEnum.Effect_RemoveSpellEffects)]
public class RemoveSpellEffects : SpellEffectHandler
{
    public RemoveSpellEffects(EffectDice effect, SpellCastHandler castHandler) : base(effect,  castHandler)
    {

    }

    protected override void Apply(IEnumerable<Fighter> targets)
    {
        short spellId = (short)Effect.Value;

        foreach (var target in targets)
        {
            target.RemoveSpellEffects(Source, spellId);
        }
    }
}