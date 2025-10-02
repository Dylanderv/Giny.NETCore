using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeBidHouseItemRemoveOkMessage : NetworkMessage
{
    public const ushort Id = 7081;
    public override ushort MessageId => Id;

    public int sellerId;

    public ExchangeBidHouseItemRemoveOkMessage()
    {
    }
    public ExchangeBidHouseItemRemoveOkMessage(int sellerId)
    {
        this.sellerId = sellerId;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteInt((int)sellerId);
    }
    public override void Deserialize(IDataReader reader)
    {
        sellerId = (int)reader.ReadInt();
    }

}