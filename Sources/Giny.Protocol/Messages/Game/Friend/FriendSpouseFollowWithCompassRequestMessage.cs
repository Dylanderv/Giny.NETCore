using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class FriendSpouseFollowWithCompassRequestMessage : NetworkMessage
{
    public const ushort Id = 199;
    public override ushort MessageId => Id;

    public bool enable;

    public FriendSpouseFollowWithCompassRequestMessage()
    {
    }
    public FriendSpouseFollowWithCompassRequestMessage(bool enable)
    {
        this.enable = enable;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteBoolean((bool)enable);
    }
    public override void Deserialize(IDataReader reader)
    {
        enable = (bool)reader.ReadBoolean();
    }

}