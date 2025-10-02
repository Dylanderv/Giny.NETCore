using Giny.Core.Network.Messages;
using Giny.Protocol.Types;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeBidHouseItemAddOkMessage : NetworkMessage
{
    public const ushort Id = 6413;
    public override ushort MessageId => Id;

    public ObjectItemToSellInBid itemInfo;

    public ExchangeBidHouseItemAddOkMessage()
    {
    }
    public ExchangeBidHouseItemAddOkMessage(ObjectItemToSellInBid itemInfo)
    {
        this.itemInfo = itemInfo;
    }
    public override void Serialize(IDataWriter writer)
    {
        itemInfo.Serialize(writer);
    }
    public override void Deserialize(IDataReader reader)
    {
        itemInfo = new ObjectItemToSellInBid();
        itemInfo.Deserialize(reader);
    }

}