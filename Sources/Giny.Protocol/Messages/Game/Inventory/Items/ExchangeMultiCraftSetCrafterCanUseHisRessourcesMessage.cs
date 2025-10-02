using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage : NetworkMessage
{
    public const ushort Id = 7719;
    public override ushort MessageId => Id;

    public bool allow;

    public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage()
    {
    }
    public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage(bool allow)
    {
        this.allow = allow;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteBoolean((bool)allow);
    }
    public override void Deserialize(IDataReader reader)
    {
        allow = (bool)reader.ReadBoolean();
    }

}