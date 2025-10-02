using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GameFightPauseMessage : NetworkMessage
{
    public const ushort Id = 5505;
    public override ushort MessageId => Id;

    public bool isPaused;

    public GameFightPauseMessage()
    {
    }
    public GameFightPauseMessage(bool isPaused)
    {
        this.isPaused = isPaused;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteBoolean((bool)isPaused);
    }
    public override void Deserialize(IDataReader reader)
    {
        isPaused = (bool)reader.ReadBoolean();
    }

}