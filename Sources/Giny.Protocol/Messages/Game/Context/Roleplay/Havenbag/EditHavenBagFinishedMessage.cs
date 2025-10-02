using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class EditHavenBagFinishedMessage : NetworkMessage
{
    public const ushort Id = 2552;
    public override ushort MessageId => Id;


    public EditHavenBagFinishedMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}