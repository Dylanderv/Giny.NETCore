using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GameEntityDispositionErrorMessage : NetworkMessage
{
    public const ushort Id = 4091;
    public override ushort MessageId => Id;


    public GameEntityDispositionErrorMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}