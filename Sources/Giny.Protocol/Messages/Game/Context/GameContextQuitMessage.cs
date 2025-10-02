using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GameContextQuitMessage : NetworkMessage
{
    public const ushort Id = 5896;
    public override ushort MessageId => Id;


    public GameContextQuitMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}