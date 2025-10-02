using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AllianceRecruitmentInvalidateMessage : NetworkMessage
{
    public const ushort Id = 3670;
    public override ushort MessageId => Id;


    public AllianceRecruitmentInvalidateMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}