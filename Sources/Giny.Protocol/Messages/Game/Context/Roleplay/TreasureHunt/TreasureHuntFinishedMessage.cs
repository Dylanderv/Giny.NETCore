using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class TreasureHuntFinishedMessage : NetworkMessage
{
    public const ushort Id = 6113;
    public override ushort MessageId => Id;

    public byte questType;

    public TreasureHuntFinishedMessage()
    {
    }
    public TreasureHuntFinishedMessage(byte questType)
    {
        this.questType = questType;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteByte((byte)questType);
    }
    public override void Deserialize(IDataReader reader)
    {
        questType = (byte)reader.ReadByte();
        if (questType < 0)
        {
            throw new System.Exception("Forbidden value (" + questType + ") on element of TreasureHuntFinishedMessage.questType.");
        }

    }

}