using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class CharactersListErrorMessage : NetworkMessage
{
    public const ushort Id = 5340;
    public override ushort MessageId => Id;


    public CharactersListErrorMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}