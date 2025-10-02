using Giny.Protocol.Enums;
using Giny.Protocol.Types;
using Giny.World.Managers.Dialogs;
using Giny.World.Managers.Entities.Characters;
using Giny.World.Records.Maps;

namespace Giny.DungeonZaap;

public class DungeonZaapDialog : ZaapDialog
{
    public override TeleporterTypeEnum TeleporterType => TeleporterTypeEnum.TELEPORTER_ZAAP;
    public DungeonZaapDialog(Character character) : base(character)
    {
        foreach (var dungeon in DungeonRecord.GetDungeonRecords())
        {
            if (dungeon.Rooms.Count <= 1)
            {
                continue;
            }

            if (dungeon.Rooms.All(x => x.MonsterIds.Count == 0))
            {
                continue;
            }
            var room = dungeon.Rooms.FirstOrDefault();

            var targetMap = MapRecord.GetMap(room.MapId);

            if (targetMap == null)
            {
                continue;
            }


            Destinations.Add(room.MapId, new TeleportDestination()
            {
                cost = GetCost(targetMap, character.Map),
                level = 1,
                type = (byte)TeleporterType,
                mapId = targetMap.Id,
                subAreaId = targetMap.SubareaId,
            });

        }
    }

    public override short GetCost(MapRecord teleporterMap, MapRecord currentMap)
    {
        return (short)(teleporterMap.Dungeon.OptimalPlayerLevel * 100);
    }
    public override void Open()
    {
        base.Open();
    }

    public override void Teleport(MapRecord map)
    {
        base.Teleport(map);
    }
}