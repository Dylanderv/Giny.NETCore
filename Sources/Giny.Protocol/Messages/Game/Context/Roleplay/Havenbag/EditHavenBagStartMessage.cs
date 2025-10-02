using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class EditHavenBagStartMessage : NetworkMessage
{
    public const ushort Id = 7016;
    public override ushort MessageId => Id;


    public EditHavenBagStartMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}