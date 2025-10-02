using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GameContextCreateErrorMessage : NetworkMessage
{
    public const ushort Id = 5580;
    public override ushort MessageId => Id;


    public GameContextCreateErrorMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}