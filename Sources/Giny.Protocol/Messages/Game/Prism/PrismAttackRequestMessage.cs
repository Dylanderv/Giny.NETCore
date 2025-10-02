using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class PrismAttackRequestMessage : NetworkMessage
{
    public const ushort Id = 2774;
    public override ushort MessageId => Id;


    public PrismAttackRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}