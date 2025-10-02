using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeMultiCraftCrafterCanUseHisRessourcesMessage : NetworkMessage
{
    public const ushort Id = 3260;
    public override ushort MessageId => Id;

    public bool allowed;

    public ExchangeMultiCraftCrafterCanUseHisRessourcesMessage()
    {
    }
    public ExchangeMultiCraftCrafterCanUseHisRessourcesMessage(bool allowed)
    {
        this.allowed = allowed;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteBoolean((bool)allowed);
    }
    public override void Deserialize(IDataReader reader)
    {
        allowed = (bool)reader.ReadBoolean();
    }

}