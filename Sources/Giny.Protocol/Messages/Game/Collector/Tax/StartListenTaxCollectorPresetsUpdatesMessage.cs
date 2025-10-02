using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class StartListenTaxCollectorPresetsUpdatesMessage : NetworkMessage
{
    public const ushort Id = 276;
    public override ushort MessageId => Id;


    public StartListenTaxCollectorPresetsUpdatesMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}