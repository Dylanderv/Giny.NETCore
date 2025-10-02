using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class FriendDeleteRequestMessage : NetworkMessage
{
    public const ushort Id = 7180;
    public override ushort MessageId => Id;

    public int accountId;

    public FriendDeleteRequestMessage()
    {
    }
    public FriendDeleteRequestMessage(int accountId)
    {
        this.accountId = accountId;
    }
    public override void Serialize(IDataWriter writer)
    {
        if (accountId < 0)
        {
            throw new System.Exception("Forbidden value (" + accountId + ") on element accountId.");
        }

        writer.WriteInt((int)accountId);
    }
    public override void Deserialize(IDataReader reader)
    {
        accountId = (int)reader.ReadInt();
        if (accountId < 0)
        {
            throw new System.Exception("Forbidden value (" + accountId + ") on element of FriendDeleteRequestMessage.accountId.");
        }

    }

}