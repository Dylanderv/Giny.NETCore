using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class FriendSpouseJoinRequestMessage : NetworkMessage
{
    public const ushort Id = 8233;
    public override ushort MessageId => Id;


    public FriendSpouseJoinRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}