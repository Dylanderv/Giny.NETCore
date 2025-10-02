using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class NpcGenericActionFailureMessage : NetworkMessage
{
    public const ushort Id = 2908;
    public override ushort MessageId => Id;


    public NpcGenericActionFailureMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}