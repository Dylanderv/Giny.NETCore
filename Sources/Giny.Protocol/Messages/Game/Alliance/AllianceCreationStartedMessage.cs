using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AllianceCreationStartedMessage : NetworkMessage
{
    public const ushort Id = 6593;
    public override ushort MessageId => Id;


    public AllianceCreationStartedMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}