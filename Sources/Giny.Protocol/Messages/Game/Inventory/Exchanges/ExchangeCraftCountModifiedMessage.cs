using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeCraftCountModifiedMessage : NetworkMessage
{
    public const ushort Id = 6783;
    public override ushort MessageId => Id;

    public int count;

    public ExchangeCraftCountModifiedMessage()
    {
    }
    public ExchangeCraftCountModifiedMessage(int count)
    {
        this.count = count;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteVarInt((int)count);
    }
    public override void Deserialize(IDataReader reader)
    {
        count = (int)reader.ReadVarInt();
    }

}