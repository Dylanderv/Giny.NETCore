using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AbstractPartyMessage : NetworkMessage
{
    public const ushort Id = 6775;
    public override ushort MessageId => Id;

    public int partyId;

    public AbstractPartyMessage()
    {
    }
    public AbstractPartyMessage(int partyId)
    {
        this.partyId = partyId;
    }
    public override void Serialize(IDataWriter writer)
    {
        if (partyId < 0)
        {
            throw new System.Exception("Forbidden value (" + partyId + ") on element partyId.");
        }

        writer.WriteVarInt((int)partyId);
    }
    public override void Deserialize(IDataReader reader)
    {
        partyId = (int)reader.ReadVarUhInt();
        if (partyId < 0)
        {
            throw new System.Exception("Forbidden value (" + partyId + ") on element of AbstractPartyMessage.partyId.");
        }

    }

}