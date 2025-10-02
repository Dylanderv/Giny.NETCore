using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class EmoteRemoveMessage : NetworkMessage
{
    public const ushort Id = 3592;
    public override ushort MessageId => Id;

    public short emoteId;

    public EmoteRemoveMessage()
    {
    }
    public EmoteRemoveMessage(short emoteId)
    {
        this.emoteId = emoteId;
    }
    public override void Serialize(IDataWriter writer)
    {
        if (emoteId < 0 || emoteId > 65535)
        {
            throw new System.Exception("Forbidden value (" + emoteId + ") on element emoteId.");
        }

        writer.WriteShort((short)emoteId);
    }
    public override void Deserialize(IDataReader reader)
    {
        emoteId = (short)reader.ReadUShort();
        if (emoteId < 0 || emoteId > 65535)
        {
            throw new System.Exception("Forbidden value (" + emoteId + ") on element of EmoteRemoveMessage.emoteId.");
        }

    }

}