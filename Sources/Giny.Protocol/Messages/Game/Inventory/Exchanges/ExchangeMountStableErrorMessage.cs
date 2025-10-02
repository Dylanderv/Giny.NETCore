using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ExchangeMountStableErrorMessage : NetworkMessage
{
    public const ushort Id = 4915;
    public override ushort MessageId => Id;


    public ExchangeMountStableErrorMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}