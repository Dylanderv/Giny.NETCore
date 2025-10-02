using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class SocialNoticeSetRequestMessage : NetworkMessage
{
    public const ushort Id = 4424;
    public override ushort MessageId => Id;


    public SocialNoticeSetRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}