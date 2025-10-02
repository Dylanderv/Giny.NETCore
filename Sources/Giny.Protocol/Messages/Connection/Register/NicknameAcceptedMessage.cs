using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class NicknameAcceptedMessage : NetworkMessage
{
    public const ushort Id = 8621;
    public override ushort MessageId => Id;


    public NicknameAcceptedMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}