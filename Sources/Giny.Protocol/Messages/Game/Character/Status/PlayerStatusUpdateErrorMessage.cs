using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class PlayerStatusUpdateErrorMessage : NetworkMessage
{
    public const ushort Id = 4470;
    public override ushort MessageId => Id;


    public PlayerStatusUpdateErrorMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}