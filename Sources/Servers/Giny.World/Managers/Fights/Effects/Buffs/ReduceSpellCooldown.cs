using Giny.Protocol.Enums;
using Giny.World.Managers.Effects;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Effects.Other;

[SpellEffectHandler(EffectsEnum.Effect_ReduceSpellCooldown)]
public class AddSpellCooldown : SpellEffectHandler
{
    public AddSpellCooldown(EffectDice effect, SpellCastHandler castHandler) : base(effect, castHandler)
    {
    }

    protected override void Apply(IEnumerable<Fighter> targets)
    {
        short spellId = (short)Effect.Min;
        short reduceDelta = (short)Effect.Value;

        foreach (var target in targets)
        {
            if (target.HasSpell(spellId))
            {
                target.ReduceSpellCooldown(Source, spellId, reduceDelta);
            }
        }
    }
}