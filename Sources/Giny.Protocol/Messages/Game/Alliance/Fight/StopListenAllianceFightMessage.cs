using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class StopListenAllianceFightMessage : NetworkMessage
{
    public const ushort Id = 6645;
    public override ushort MessageId => Id;


    public StopListenAllianceFightMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}