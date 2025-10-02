using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeItemAutoCraftStopedMessage : NetworkMessage
{
    public const ushort Id = 3953;
    public override ushort MessageId => Id;

    public byte reason;

    public ExchangeItemAutoCraftStopedMessage()
    {
    }
    public ExchangeItemAutoCraftStopedMessage(byte reason)
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
    }

}