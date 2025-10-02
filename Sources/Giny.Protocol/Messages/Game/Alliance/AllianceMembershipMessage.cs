using Giny.Protocol.Types;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AllianceMembershipMessage : AllianceJoinedMessage
{
    public new const ushort Id = 549;
    public override ushort MessageId => Id;


    public AllianceMembershipMessage()
    {
    }
    public AllianceMembershipMessage(AllianceInformation allianceInfo, int rankId)
    {
        this.allianceInfo = allianceInfo;
        this.rankId = rankId;
    }
    public override void Serialize(IDataWriter writer)
    {
        base.Serialize(writer);
    }
    public override void Deserialize(IDataReader reader)
    {
        base.Deserialize(reader);
    }

}