using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ForceAccountErrorMessage : NetworkMessage
{
    public const ushort Id = 8978;
    public override ushort MessageId => Id;


    public ForceAccountErrorMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}