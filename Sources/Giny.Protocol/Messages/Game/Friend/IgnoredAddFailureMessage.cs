using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class IgnoredAddFailureMessage : NetworkMessage
{
    public const ushort Id = 6611;
    public override ushort MessageId => Id;

    public byte reason;

    public IgnoredAddFailureMessage()
    {
    }
    public IgnoredAddFailureMessage(byte reason)
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
            throw new System.Exception("Forbidden value (" + reason + ") on element of IgnoredAddFailureMessage.reason.");
        }

    }

}