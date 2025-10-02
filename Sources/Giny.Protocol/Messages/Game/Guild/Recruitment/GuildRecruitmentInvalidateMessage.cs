using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GuildRecruitmentInvalidateMessage : NetworkMessage
{
    public const ushort Id = 1620;
    public override ushort MessageId => Id;


    public GuildRecruitmentInvalidateMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}