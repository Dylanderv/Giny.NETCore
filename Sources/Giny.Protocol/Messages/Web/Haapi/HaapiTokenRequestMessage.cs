using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class HaapiTokenRequestMessage : NetworkMessage
{
    public const ushort Id = 6608;
    public override ushort MessageId => Id;


    public HaapiTokenRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}