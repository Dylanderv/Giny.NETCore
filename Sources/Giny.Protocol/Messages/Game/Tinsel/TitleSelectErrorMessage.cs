using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class TitleSelectErrorMessage : NetworkMessage
{
    public const ushort Id = 7277;
    public override ushort MessageId => Id;

    public byte reason;

    public TitleSelectErrorMessage()
    {
    }
    public TitleSelectErrorMessage(byte reason)
    {
        this.reason = reason;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteByte((byte)reason);
    }
    public override void Deserialize(IDataReader reader)
    {
        reason = (byte)reader.ReadByte();
        if (reason < 0)
        {
            throw new System.Exception("Forbidden value (" + reason + ") on element of TitleSelectSystem.ExceptionMessage.reason.");
        }

    }

}