using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class FriendStatusShareStateMessage : NetworkMessage
{
    public const ushort Id = 7408;
    public override ushort MessageId => Id;

    public bool share;

    public FriendStatusShareStateMessage()
    {
    }
    public FriendStatusShareStateMessage(bool share)
    {
        this.share = share;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteBoolean((bool)share);
    }
    public override void Deserialize(IDataReader reader)
    {
        share = (bool)reader.ReadBoolean();
    }

}