using Giny.Protocol.Enums;
using Giny.World.Managers.Entities.Characters;

namespace Giny.World.Managers.Parties;

public class ClassicalParty : Party
{
    public override PartyTypeEnum Type
    {
        get
        {
            return PartyTypeEnum.PARTY_TYPE_CLASSICAL;
        }
    }
    public override byte MaxParticipants
    {
        get
        {
            return 8 + 1;
        }
    }
    public ClassicalParty(int partyId, Character leader)
        : base(partyId, leader)
    {
    }

}