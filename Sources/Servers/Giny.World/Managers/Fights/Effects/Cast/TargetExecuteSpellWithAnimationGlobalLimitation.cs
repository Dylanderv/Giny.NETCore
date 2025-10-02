using Giny.Protocol.Enums;
using Giny.World.Managers.Effects;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Effects.Cast;

[SpellEffectHandler(EffectsEnum.Effect_TargetExecuteSpellWithAnimationGlobalLimitation)]
public class TargetExecuteSpellWithAnimationGlobalLimitation : SpellEffectHandler
{
    public TargetExecuteSpellWithAnimationGlobalLimitation(EffectDice effect, SpellCastHandler castHandler) : base(effect, castHandler)
    {

    }

    protected override void Apply(IEnumerable<Fighter> targets)
    {
        Spell spell = CreateCastedSpell();

        foreach (var target in targets)
        {
            SpellCast cast = new SpellCast(target, spell, target.Cell, CastHandler.Cast);
            cast.Token = this.GetTriggerToken<ITriggerToken>();
            cast.Force = true;
            cast.Silent = true;
            target.CastSpell(cast);
        }
    }
}