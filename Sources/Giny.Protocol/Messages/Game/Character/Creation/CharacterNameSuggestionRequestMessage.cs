using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class CharacterNameSuggestionRequestMessage : NetworkMessage
{
    public const ushort Id = 3929;
    public override ushort MessageId => Id;


    public CharacterNameSuggestionRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}