using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class FriendsGetListMessage : NetworkMessage
{
    public const ushort Id = 3554;
    public override ushort MessageId => Id;


    public FriendsGetListMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}