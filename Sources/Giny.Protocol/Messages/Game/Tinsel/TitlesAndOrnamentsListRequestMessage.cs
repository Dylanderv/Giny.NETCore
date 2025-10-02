using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class TitlesAndOrnamentsListRequestMessage : NetworkMessage
{
    public const ushort Id = 7199;
    public override ushort MessageId => Id;


    public TitlesAndOrnamentsListRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}