using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AllianceDeleteApplicationRequestMessage : NetworkMessage
{
    public const ushort Id = 4504;
    public override ushort MessageId => Id;


    public AllianceDeleteApplicationRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}