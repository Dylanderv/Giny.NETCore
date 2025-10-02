using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class BreachExitRequestMessage : NetworkMessage
{
    public const ushort Id = 7787;
    public override ushort MessageId => Id;


    public BreachExitRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}