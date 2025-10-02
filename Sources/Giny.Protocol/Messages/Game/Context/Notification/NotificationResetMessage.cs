using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class NotificationResetMessage : NetworkMessage
{
    public const ushort Id = 9791;
    public override ushort MessageId => Id;


    public NotificationResetMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}