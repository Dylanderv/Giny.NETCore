using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class CharacterCanBeCreatedRequestMessage : NetworkMessage
{
    public const ushort Id = 7257;
    public override ushort MessageId => Id;


    public CharacterCanBeCreatedRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}