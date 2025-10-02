using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ShortcutBarAddErrorMessage : NetworkMessage
{
    public const ushort Id = 1938;
    public override ushort MessageId => Id;

    public byte error;

    public ShortcutBarAddErrorMessage()
    {
    }
    public ShortcutBarAddErrorMessage(byte error)
    {
        this.error = error;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteByte((byte)error);
    }
    public override void Deserialize(IDataReader reader)
    {
        error = (byte)reader.ReadByte();
        if (error < 0)
        {
            throw new System.Exception("Forbidden value (" + error + ") on element of ShortcutBarAddSystem.ExceptionMessage.error.");
        }

    }

}