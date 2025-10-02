using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class SpouseGetInformationsMessage : NetworkMessage
{
    public const ushort Id = 7971;
    public override ushort MessageId => Id;


    public SpouseGetInformationsMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}