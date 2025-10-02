using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AuthenticationTicketRefusedMessage : NetworkMessage
{
    public const ushort Id = 1235;
    public override ushort MessageId => Id;


    public AuthenticationTicketRefusedMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}