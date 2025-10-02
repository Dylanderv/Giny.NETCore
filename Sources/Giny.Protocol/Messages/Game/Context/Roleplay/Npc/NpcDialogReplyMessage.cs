using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class NpcDialogReplyMessage : NetworkMessage
{
    public const ushort Id = 7517;
    public override ushort MessageId => Id;

    public int replyId;

    public NpcDialogReplyMessage()
    {
    }
    public NpcDialogReplyMessage(int replyId)
    {
        this.replyId = replyId;
    }
    public override void Serialize(IDataWriter writer)
    {
        if (replyId < 0)
        {
            throw new System.Exception("Forbidden value (" + replyId + ") on element replyId.");
        }

        writer.WriteVarInt((int)replyId);
    }
    public override void Deserialize(IDataReader reader)
    {
        replyId = (int)reader.ReadVarUhInt();
        if (replyId < 0)
        {
            throw new System.Exception("Forbidden value (" + replyId + ") on element of NpcDialogReplyMessage.replyId.");
        }

    }

}