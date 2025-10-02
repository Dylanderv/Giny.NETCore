using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class CharacterLoadingCompleteMessage : NetworkMessage
{
    public const ushort Id = 5077;
    public override ushort MessageId => Id;


    public CharacterLoadingCompleteMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}