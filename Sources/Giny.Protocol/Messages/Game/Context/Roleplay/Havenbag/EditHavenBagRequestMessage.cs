using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class EditHavenBagRequestMessage : NetworkMessage
{
    public const ushort Id = 474;
    public override ushort MessageId => Id;


    public EditHavenBagRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}