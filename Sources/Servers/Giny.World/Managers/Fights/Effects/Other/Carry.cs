using Giny.Protocol.Enums;
using Giny.World.Managers.Effects;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;

namespace Giny.World.Managers.Fights.Effects.Other;

[SpellEffectHandler(EffectsEnum.Effect_Carry)]
public class Carry : SpellEffectHandler
{


    public Carry(EffectDice effect, SpellCastHandler castHandler) : base(effect, castHandler)
    {
    }

    protected override void Apply(IEnumerable<Fighter> targets)
    {
        foreach (var target in targets)
        {
            if (!Source.IsCarrying() && target.CanBeCarried() && target != Source)
            {
                Source.Carry(target, this);

                   
            }
        }


    }
}