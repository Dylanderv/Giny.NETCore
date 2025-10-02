using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ChangeThemeRequestMessage : NetworkMessage
{
    public const ushort Id = 1629;
    public override ushort MessageId => Id;

    public byte theme;

    public ChangeThemeRequestMessage()
    {
    }
    public ChangeThemeRequestMessage(byte theme)
    {
        this.theme = theme;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteByte((byte)theme);
    }
    public override void Deserialize(IDataReader reader)
    {
        theme = (byte)reader.ReadByte();
    }

}