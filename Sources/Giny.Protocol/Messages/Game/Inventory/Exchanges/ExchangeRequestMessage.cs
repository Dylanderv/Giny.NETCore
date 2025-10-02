using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeRequestMessage : NetworkMessage
{
    public const ushort Id = 2858;
    public override ushort MessageId => Id;

    public byte exchangeType;

    public ExchangeRequestMessage()
    {
    }
    public ExchangeRequestMessage(byte exchangeType)
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