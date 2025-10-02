using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GuildGetChestTabContributionsRequestMessage : NetworkMessage
{
    public const ushort Id = 9107;
    public override ushort MessageId => Id;


    public GuildGetChestTabContributionsRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}