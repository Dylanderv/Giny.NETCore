using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AllianceGetRecruitmentInformationMessage : NetworkMessage
{
    public const ushort Id = 5947;
    public override ushort MessageId => Id;


    public AllianceGetRecruitmentInformationMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}