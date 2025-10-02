using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeRequestedMessage : NetworkMessage
{
    public const ushort Id = 6601;
    public override ushort MessageId => Id;

    public byte exchangeType;

    public ExchangeRequestedMessage()
    {
    }
    public ExchangeRequestedMessage(byte exchangeType)
    {
        this.exchangeType = exchangeType;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteByte((byte)exchangeType);
    }
    public override void Deserialize(IDataReader reader)
    {
        exchangeType = (byte)reader.ReadByte();
    }

}