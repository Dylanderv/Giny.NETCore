using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GameMapChangeOrientationRequestMessage : NetworkMessage
{
    public const ushort Id = 7489;
    public override ushort MessageId => Id;

    public byte direction;

    public GameMapChangeOrientationRequestMessage()
    {
    }
    public GameMapChangeOrientationRequestMessage(byte direction)
    {
        this.direction = direction;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteByte((byte)direction);
    }
    public override void Deserialize(IDataReader reader)
    {
        direction = (byte)reader.ReadByte();
        if (direction < 0)
        {
            throw new System.Exception("Forbidden value (" + direction + ") on element of GameMapChangeOrientationRequestMessage.direction.");
        }

    }

}