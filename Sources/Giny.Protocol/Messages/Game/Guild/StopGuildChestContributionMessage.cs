using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class StopGuildChestContributionMessage : NetworkMessage
{
    public const ushort Id = 9562;
    public override ushort MessageId => Id;


    public StopGuildChestContributionMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}