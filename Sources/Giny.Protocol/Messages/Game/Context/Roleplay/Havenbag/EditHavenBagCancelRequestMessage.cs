using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class EditHavenBagCancelRequestMessage : NetworkMessage
{
    public const ushort Id = 4669;
    public override ushort MessageId => Id;


    public EditHavenBagCancelRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}