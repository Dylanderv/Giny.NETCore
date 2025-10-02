using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class StartGuildChestContributionMessage : NetworkMessage
{
    public const ushort Id = 3909;
    public override ushort MessageId => Id;


    public StartGuildChestContributionMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}