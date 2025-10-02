using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class StartListenAllianceFightMessage : NetworkMessage
{
    public const ushort Id = 4134;
    public override ushort MessageId => Id;


    public StartListenAllianceFightMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}