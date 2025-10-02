using Giny.Protocol.Enums;
using Giny.World.Managers.Effects;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;
using Giny.World.Managers.Maps;

namespace Giny.World.Managers.Fights.Effects.Movements;

[SpellEffectHandler(EffectsEnum.Effect_SymetricTargetTeleport)]
public class SymetricTargetTeleport : SpellEffectHandler
{
    public SymetricTargetTeleport(EffectDice effect, SpellCastHandler castHandler) : base(effect, castHandler)
    {

    }

    protected override void Apply(IEnumerable<Fighter> targets)
    {
        var target = Source.Fight.GetFighter(TargetCell.Id);

        if (target == null)
        {
            return;
        }


        var targetPoint = new MapPoint((2 * target.Cell.Point.X - Source.Cell.Point.X), (2 * target.Cell.Point.Y - Source.Cell.Point.Y));

        var telefrag = Source.Teleport(Source, Source.Fight.Map.GetCell(targetPoint));

        if (telefrag != null)
        {
            this.CastHandler.AddTelefrag(telefrag);
        }

        /* foreach (var target in targets)
         {
             unused ?
         } */
    }
}