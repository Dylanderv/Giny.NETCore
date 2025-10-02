using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GuildModificationResultMessage : NetworkMessage
{
    public const ushort Id = 295;
    public override ushort MessageId => Id;

    public byte result;

    public GuildModificationResultMessage()
    {
    }
    public GuildModificationResultMessage(byte result)
    {
        this.result = result;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteByte((byte)result);
    }
    public override void Deserialize(IDataReader reader)
    {
        result = (byte)reader.ReadByte();
        if (result < 0)
        {
            throw new System.Exception("Forbidden value (" + result + ") on element of GuildModificationResultMessage.result.");
        }

    }

}