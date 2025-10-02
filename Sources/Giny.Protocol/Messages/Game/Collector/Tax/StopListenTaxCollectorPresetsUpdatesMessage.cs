using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class StopListenTaxCollectorPresetsUpdatesMessage : NetworkMessage
{
    public const ushort Id = 7995;
    public override ushort MessageId => Id;


    public StopListenTaxCollectorPresetsUpdatesMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}