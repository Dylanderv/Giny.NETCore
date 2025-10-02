using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class HelloGameMessage : NetworkMessage
{
    public const ushort Id = 858;
    public override ushort MessageId => Id;


    public HelloGameMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}