using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class CharactersListRequestMessage : NetworkMessage
{
    public const ushort Id = 3965;
    public override ushort MessageId => Id;


    public CharactersListRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}