using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ForceAccountMessage : NetworkMessage
{
    public const ushort Id = 78;
    public override ushort MessageId => Id;

    public int accountId;

    public ForceAccountMessage()
    {
    }
    public ForceAccountMessage(int accountId)
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
            throw new System.Exception("Forbidden value (" + accountId + ") on element of ForceAccountMessage.accountId.");
        }

    }

}