using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class CharacterSelectedForceReadyMessage : NetworkMessage
{
    public const ushort Id = 9079;
    public override ushort MessageId => Id;


    public CharacterSelectedForceReadyMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}