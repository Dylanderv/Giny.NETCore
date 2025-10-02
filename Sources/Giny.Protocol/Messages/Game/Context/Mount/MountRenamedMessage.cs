using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class MountRenamedMessage : NetworkMessage
{
    public const ushort Id = 2577;
    public override ushort MessageId => Id;

    public int mountId;
    public string name;

    public MountRenamedMessage()
    {
    }
    public MountRenamedMessage(int mountId, string name)
    {
        this.mountId = mountId;
        this.name = name;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteVarInt((int)mountId);
        writer.WriteUTF((string)name);
    }
    public override void Deserialize(IDataReader reader)
    {
        mountId = (int)reader.ReadVarInt();
        name = (string)reader.ReadUTF();
    }

}