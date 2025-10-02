using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeObjectModifyPricedMessage : ExchangeObjectMovePricedMessage
{
    public new const ushort Id = 5202;
    public override ushort MessageId => Id;


    public ExchangeObjectModifyPricedMessage()
    {
    }
    public ExchangeObjectModifyPricedMessage(int objectUID, int quantity, long price)
    {
        this.objectUID = objectUID;
        this.quantity = quantity;
        this.price = price;
    }
    public override void Serialize(IDataWriter writer)
    {
        base.Serialize(writer);
    }
    public override void Deserialize(IDataReader reader)
    {
        base.Deserialize(reader);
    }

}