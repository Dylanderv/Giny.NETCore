using Giny.Core.Network.Messages;
using Giny.Protocol.Types;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeStartedBidBuyerMessage : NetworkMessage
{
    public const ushort Id = 2202;
    public override ushort MessageId => Id;

    public SellerBuyerDescriptor buyerDescriptor;

    public ExchangeStartedBidBuyerMessage()
    {
    }
    public ExchangeStartedBidBuyerMessage(SellerBuyerDescriptor buyerDescriptor)
    {
        this.buyerDescriptor = buyerDescriptor;
    }
    public override void Serialize(IDataWriter writer)
    {
        buyerDescriptor.Serialize(writer);
    }
    public override void Deserialize(IDataReader reader)
    {
        buyerDescriptor = new SellerBuyerDescriptor();
        buyerDescriptor.Deserialize(reader);
    }

}