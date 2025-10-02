using Giny.Protocol.Custom.Enums;
using Giny.World.Managers.Effects;
using Giny.World.Managers.Fights.Cast;
using Giny.World.Managers.Fights.Fighters;
using Giny.World.Managers.Fights.Movements;
using Giny.World.Managers.Fights.Zones;
using Giny.World.Records.Maps;
using System.Drawing;

namespace Giny.World.Managers.Fights.Marks;

public class Trap : Mark
{
    public override bool InterceptMovement => true;

    public override GameActionMarkTypeEnum Type => GameActionMarkTypeEnum.TRAP;

    public Trap(int id, EffectDice effect, MarkTriggerType triggers, Zone zone, Color color,
        Fighter source, CellRecord centerCell, Spell markSpell, Spell triggerSpell) :
        base(id, effect, zone, triggers, color, source, centerCell, markSpell, triggerSpell)
    {

    }

    public override bool IsVisibleFor(CharacterFighter fighter)
    {
        return Source.IsFriendlyWith(fighter);
    }

    public override void Trigger(Fighter target, MarkTriggerType triggerType, ITriggerToken? token)
    {
        if (token != null && triggerType == MarkTriggerType.OnMove && token is Movement movement)
        {
            if (movement.Type == MovementType.SwitchPosition)
            {
                return;
            }
        }
        Source.Fight.RemoveMark(this);
        ApplyEffects();
    }

    public override void OnAdded()
    {

    }

    public override void OnRemoved()
    {

    }

    public override bool OnTurnBegin()
    {
        return false;
    }

    public override void OnUpdated()
    {

    }
}