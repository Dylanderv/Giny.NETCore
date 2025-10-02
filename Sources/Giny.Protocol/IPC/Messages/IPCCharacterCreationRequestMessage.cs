using Giny.Core.IO.Interfaces;
using Giny.Core.Network.IPC;

namespace Giny.Protocol.IPC.Messages;

public class IPCCharacterCreationRequestMessage : IPCMessage
{
    public const ushort Id = 7;

    public override ushort MessageId
    {
        get
        {
            return Id; 
        }
    }

    public int accountId;

    public long characterId;

    public IPCCharacterCreationRequestMessage(int accountId, long characterId)
    {
        this.accountId = accountId;
        this.characterId = characterId;
    }

    public IPCCharacterCreationRequestMessage()
    {

    }

    public override void Serialize(IDataWriter writer)
    {
        writer.WriteInt(accountId);
        writer.WriteLong(characterId);
    }

    public override void Deserialize(IDataReader reader)
    {
        this.accountId = reader.ReadInt();
        this.characterId = reader.ReadLong();
    }
}