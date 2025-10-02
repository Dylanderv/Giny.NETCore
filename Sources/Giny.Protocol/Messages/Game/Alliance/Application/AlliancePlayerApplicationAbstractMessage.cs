using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AlliancePlayerApplicationAbstractMessage : NetworkMessage
{
    public const ushort Id = 4220;
    public override ushort MessageId => Id;


    public AlliancePlayerApplicationAbstractMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}