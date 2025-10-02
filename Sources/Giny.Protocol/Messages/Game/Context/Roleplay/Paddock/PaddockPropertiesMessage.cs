using Giny.Core.Network.Messages;
using Giny.Protocol.Types;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class PaddockPropertiesMessage : NetworkMessage
{
    public const ushort Id = 5635;
    public override ushort MessageId => Id;

    public PaddockInstancesInformations properties;

    public PaddockPropertiesMessage()
    {
    }
    public PaddockPropertiesMessage(PaddockInstancesInformations properties)
    {
        this.properties = properties;
    }
    public override void Serialize(IDataWriter writer)
    {
        properties.Serialize(writer);
    }
    public override void Deserialize(IDataReader reader)
    {
        properties = new PaddockInstancesInformations();
        properties.Deserialize(reader);
    }

}