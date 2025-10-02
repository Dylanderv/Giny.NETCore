using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ZaapRespawnSaveRequestMessage : NetworkMessage
{
    public const ushort Id = 153;
    public override ushort MessageId => Id;


    public ZaapRespawnSaveRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}