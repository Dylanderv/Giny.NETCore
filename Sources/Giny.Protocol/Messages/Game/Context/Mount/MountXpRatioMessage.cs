using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class MountXpRatioMessage : NetworkMessage
{
    public const ushort Id = 2899;
    public override ushort MessageId => Id;

    public byte ratio;

    public MountXpRatioMessage()
    {
    }
    public MountXpRatioMessage(byte ratio)
    {
        this.ratio = ratio;
    }
    public override void Serialize(IDataWriter writer)
    {
        if (ratio < 0)
        {
            throw new System.Exception("Forbidden value (" + ratio + ") on element ratio.");
        }

        writer.WriteByte((byte)ratio);
    }
    public override void Deserialize(IDataReader reader)
    {
        ratio = (byte)reader.ReadByte();
        if (ratio < 0)
        {
            throw new System.Exception("Forbidden value (" + ratio + ") on element of MountXpRatioMessage.ratio.");
        }

    }

}