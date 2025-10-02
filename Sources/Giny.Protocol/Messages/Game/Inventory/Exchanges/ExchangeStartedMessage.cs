using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeStartedMessage : NetworkMessage
{
    public const ushort Id = 3414;
    public override ushort MessageId => Id;

    public byte exchangeType;

    public ExchangeStartedMessage()
    {
    }
    public ExchangeStartedMessage(byte exchangeType)
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