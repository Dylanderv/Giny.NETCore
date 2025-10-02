using Giny.Protocol.Enums;
using Giny.World.Managers.Effects;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Effects.Cast;

/*
 * Mot Blessant (chaque cible lance le sort)
 * Invocation Osamodas
 */
[SpellEffectHandler(EffectsEnum.Effect_TargetExecuteSpellOnSource)]
public class TargetExecuteSpellOnSource : SpellEffectHandler
{
    public TargetExecuteSpellOnSource(EffectDice effect, SpellCastHandler castHandler) : base(effect, castHandler)
    {

    }

    protected override void Apply(IEnumerable<Fighter> targets)
    {
        Spell spell = CreateCastedSpell();

        ITriggerToken token = this.GetTriggerToken<ITriggerToken>();

        var targetCell = Source.Cell;

        if (token != null)
        {
            targetCell = token.GetSource().Cell;
        }


        foreach (var target in targets)
        {
            SpellCast cast = new SpellCast(target, spell, targetCell, CastHandler.Cast);
            cast.Token = this.GetTriggerToken<ITriggerToken>();
            cast.Force = true;
            cast.Silent = true;
            target.CastSpell(cast);
        }
    }
}