using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AuthenticationTicketAcceptedMessage : NetworkMessage
{
    public const ushort Id = 170;
    public override ushort MessageId => Id;


    public AuthenticationTicketAcceptedMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}