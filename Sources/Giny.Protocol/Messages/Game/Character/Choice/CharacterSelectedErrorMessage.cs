using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class CharacterSelectedErrorMessage : NetworkMessage
{
    public const ushort Id = 6440;
    public override ushort MessageId => Id;


    public CharacterSelectedErrorMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}