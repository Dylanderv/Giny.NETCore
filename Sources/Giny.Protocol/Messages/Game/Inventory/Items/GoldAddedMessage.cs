using Giny.Core.Network.Messages;
using Giny.Protocol.Types;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GoldAddedMessage : NetworkMessage
{
    public const ushort Id = 7533;
    public override ushort MessageId => Id;

    public GoldItem gold;

    public GoldAddedMessage()
    {
    }
    public GoldAddedMessage(GoldItem gold)
    {
        this.gold = gold;
    }
    public override void Serialize(IDataWriter writer)
    {
        gold.Serialize(writer);
    }
    public override void Deserialize(IDataReader reader)
    {
        gold = new GoldItem();
        gold.Deserialize(reader);
    }

}