using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ChallengeModSelectMessage : NetworkMessage
{
    public const ushort Id = 3759;
    public override ushort MessageId => Id;

    public byte challengeMod;

    public ChallengeModSelectMessage()
    {
    }
    public ChallengeModSelectMessage(byte challengeMod)
    {
        this.challengeMod = challengeMod;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteByte((byte)challengeMod);
    }
    public override void Deserialize(IDataReader reader)
    {
        challengeMod = (byte)reader.ReadByte();
        if (challengeMod < 0)
        {
            throw new System.Exception("Forbidden value (" + challengeMod + ") on element of ChallengeModSelectMessage.challengeMod.");
        }

    }

}