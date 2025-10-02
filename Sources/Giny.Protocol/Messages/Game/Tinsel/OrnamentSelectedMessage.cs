using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class OrnamentSelectedMessage : NetworkMessage
{
    public const ushort Id = 439;
    public override ushort MessageId => Id;

    public short ornamentId;

    public OrnamentSelectedMessage()
    {
    }
    public OrnamentSelectedMessage(short ornamentId)
    {
        this.ornamentId = ornamentId;
    }
    public override void Serialize(IDataWriter writer)
    {
        if (ornamentId < 0)
        {
            throw new System.Exception("Forbidden value (" + ornamentId + ") on element ornamentId.");
        }

        writer.WriteVarShort((short)ornamentId);
    }
    public override void Deserialize(IDataReader reader)
    {
        ornamentId = (short)reader.ReadVarUhShort();
        if (ornamentId < 0)
        {
            throw new System.Exception("Forbidden value (" + ornamentId + ") on element of OrnamentSelectedMessage.ornamentId.");
        }

    }

}