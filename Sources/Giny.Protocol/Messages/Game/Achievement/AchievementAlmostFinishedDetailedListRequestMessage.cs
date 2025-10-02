using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AchievementAlmostFinishedDetailedListRequestMessage : NetworkMessage
{
    public const ushort Id = 8667;
    public override ushort MessageId => Id;


    public AchievementAlmostFinishedDetailedListRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}