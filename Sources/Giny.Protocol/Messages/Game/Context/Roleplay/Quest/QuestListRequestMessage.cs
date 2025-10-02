using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class QuestListRequestMessage : NetworkMessage
{
    public const ushort Id = 804;
    public override ushort MessageId => Id;


    public QuestListRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}