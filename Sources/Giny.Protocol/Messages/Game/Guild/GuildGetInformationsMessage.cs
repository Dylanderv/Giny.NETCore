using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GuildGetInformationsMessage : NetworkMessage
{
    public const ushort Id = 5890;
    public override ushort MessageId => Id;

    public byte infoType;

    public GuildGetInformationsMessage()
    {
    }
    public GuildGetInformationsMessage(byte infoType)
    {
        this.infoType = infoType;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteByte((byte)infoType);
    }
    public override void Deserialize(IDataReader reader)
    {
        infoType = (byte)reader.ReadByte();
        if (infoType < 0)
        {
            throw new System.Exception("Forbidden value (" + infoType + ") on element of GuildGetInformationsMessage.infoType.");
        }

    }

}