using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeCraftResultMessage : NetworkMessage
{
    public const ushort Id = 67;
    public override ushort MessageId => Id;

    public byte craftResult;

    public ExchangeCraftResultMessage()
    {
    }
    public ExchangeCraftResultMessage(byte craftResult)
    {
        this.craftResult = craftResult;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteByte((byte)craftResult);
    }
    public override void Deserialize(IDataReader reader)
    {
        craftResult = (byte)reader.ReadByte();
        if (craftResult < 0)
        {
            throw new System.Exception("Forbidden value (" + craftResult + ") on element of ExchangeCraftResultMessage.craftResult.");
        }

    }

}