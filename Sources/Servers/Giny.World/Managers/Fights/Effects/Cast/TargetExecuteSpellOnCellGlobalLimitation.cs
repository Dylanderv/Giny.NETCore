using Giny.Protocol.Enums;
using Giny.World.Managers.Effects;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Effects.Cast;

/*
 * Courone épine
 */
[SpellEffectHandler(EffectsEnum.Effect_TargetExecuteSpellOnCellGlobalLimitation)]
public class TargetExecuteSpellOnCellGlobalLimitation : SpellEffectHandler
{
    public TargetExecuteSpellOnCellGlobalLimitation(EffectDice effect, SpellCastHandler castHandler) : base(effect, castHandler)
    {

    }

    protected override void Apply(IEnumerable<Fighter> targets)
    {
        Spell spell = CreateCastedSpell();

        foreach (var target in targets)  // target , sure 
        {
            SpellCast cast = new SpellCast(target, spell, TargetCell, CastHandler.Cast);  // TargetCell, sure ! 
            cast.Token = this.GetTriggerToken<ITriggerToken>();
            cast.Force = true;
            cast.Silent = true;
            target.CastSpell(cast);
        }
    }
}