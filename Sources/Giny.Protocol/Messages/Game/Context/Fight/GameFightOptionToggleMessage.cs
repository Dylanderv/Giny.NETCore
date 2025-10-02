using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GameFightOptionToggleMessage : NetworkMessage
{
    public const ushort Id = 4020;
    public override ushort MessageId => Id;

    public byte option;

    public GameFightOptionToggleMessage()
    {
    }
    public GameFightOptionToggleMessage(byte option)
    {
        this.option = option;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteByte((byte)option);
    }
    public override void Deserialize(IDataReader reader)
    {
        option = (byte)reader.ReadByte();
        if (option < 0)
        {
            throw new System.Exception("Forbidden value (" + option + ") on element of GameFightOptionToggleMessage.option.");
        }

    }

}