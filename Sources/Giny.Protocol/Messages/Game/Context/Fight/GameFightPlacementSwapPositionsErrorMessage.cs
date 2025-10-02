using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GameFightPlacementSwapPositionsErrorMessage : NetworkMessage
{
    public const ushort Id = 9969;
    public override ushort MessageId => Id;


    public GameFightPlacementSwapPositionsErrorMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}