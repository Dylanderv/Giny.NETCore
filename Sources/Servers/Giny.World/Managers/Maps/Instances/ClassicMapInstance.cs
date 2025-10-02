using Giny.Protocol.Messages;
using Giny.World.Managers.Entities.Characters;
using Giny.World.Records.Maps;

namespace Giny.World.Managers.Maps.Instances;

public class ClassicMapInstance : MapInstance
{
    public ClassicMapInstance(MapRecord record) : base(record)
    {

    }

    public override MapComplementaryInformationsDataMessage GetMapComplementaryInformationsDataMessage(Character character)
    {
        return new MapComplementaryInformationsDataMessage(character.Map.SubareaId, Record.Id, GetHousesInformations(), GetGameRolePlayActorsInformations(character),
            GetInteractiveElements(character), GetStatedElements(), GetMapObstacles(), GetFightsCommonInformations(), HasAgressiveMonsters(),
            GetFightStartingPositions());
    }


}