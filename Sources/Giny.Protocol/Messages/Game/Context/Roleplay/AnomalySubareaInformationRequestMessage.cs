using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AnomalySubareaInformationRequestMessage : NetworkMessage
{
    public const ushort Id = 5036;
    public override ushort MessageId => Id;


    public AnomalySubareaInformationRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}