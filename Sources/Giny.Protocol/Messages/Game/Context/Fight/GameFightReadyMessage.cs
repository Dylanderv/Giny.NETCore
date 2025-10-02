using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GameFightReadyMessage : NetworkMessage
{
    public const ushort Id = 5577;
    public override ushort MessageId => Id;

    public bool isReady;

    public GameFightReadyMessage()
    {
    }
    public GameFightReadyMessage(bool isReady)
    {
        this.isReady = isReady;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteBoolean((bool)isReady);
    }
    public override void Deserialize(IDataReader reader)
    {
        isReady = (bool)reader.ReadBoolean();
    }

}