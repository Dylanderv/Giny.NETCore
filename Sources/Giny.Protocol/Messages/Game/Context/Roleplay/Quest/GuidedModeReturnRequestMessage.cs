using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GuidedModeReturnRequestMessage : NetworkMessage
{
    public const ushort Id = 4746;
    public override ushort MessageId => Id;


    public GuidedModeReturnRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}