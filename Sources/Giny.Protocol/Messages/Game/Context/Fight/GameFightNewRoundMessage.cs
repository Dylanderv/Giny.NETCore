using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GameFightNewRoundMessage : NetworkMessage
{
    public const ushort Id = 1322;
    public override ushort MessageId => Id;

    public int roundNumber;

    public GameFightNewRoundMessage()
    {
    }
    public GameFightNewRoundMessage(int roundNumber)
    {
        this.roundNumber = roundNumber;
    }
    public override void Serialize(IDataWriter writer)
    {
        if (roundNumber < 0)
        {
            throw new System.Exception("Forbidden value (" + roundNumber + ") on element roundNumber.");
        }

        writer.WriteVarInt((int)roundNumber);
    }
    public override void Deserialize(IDataReader reader)
    {
        roundNumber = (int)reader.ReadVarUhInt();
        if (roundNumber < 0)
        {
            throw new System.Exception("Forbidden value (" + roundNumber + ") on element of GameFightNewRoundMessage.roundNumber.");
        }

    }

}