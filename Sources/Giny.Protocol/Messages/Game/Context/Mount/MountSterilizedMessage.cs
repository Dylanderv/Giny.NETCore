using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class MountSterilizedMessage : NetworkMessage
{
    public const ushort Id = 5176;
    public override ushort MessageId => Id;

    public int mountId;

    public MountSterilizedMessage()
    {
    }
    public MountSterilizedMessage(int mountId)
    {
        this.mountId = mountId;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteVarInt((int)mountId);
    }
    public override void Deserialize(IDataReader reader)
    {
        mountId = (int)reader.ReadVarInt();
    }

}