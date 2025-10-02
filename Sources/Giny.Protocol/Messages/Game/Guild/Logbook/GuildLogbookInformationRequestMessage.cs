using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GuildLogbookInformationRequestMessage : NetworkMessage
{
    public const ushort Id = 7560;
    public override ushort MessageId => Id;


    public GuildLogbookInformationRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}