using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AlreadyConnectedMessage : NetworkMessage
{
    public const ushort Id = 2660;
    public override ushort MessageId => Id;


    public AlreadyConnectedMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}