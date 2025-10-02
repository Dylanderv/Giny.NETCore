using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class StatsUpgradeResultMessage : NetworkMessage
{
    public const ushort Id = 7979;
    public override ushort MessageId => Id;

    public byte result;
    public short nbCharacBoost;

    public StatsUpgradeResultMessage()
    {
    }
    public StatsUpgradeResultMessage(byte result, short nbCharacBoost)
    {
        this.result = result;
        this.nbCharacBoost = nbCharacBoost;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteByte((byte)result);
        if (nbCharacBoost < 0)
        {
            throw new System.Exception("Forbidden value (" + nbCharacBoost + ") on element nbCharacBoost.");
        }

        writer.WriteVarShort((short)nbCharacBoost);
    }
    public override void Deserialize(IDataReader reader)
    {
        result = (byte)reader.ReadByte();
        nbCharacBoost = (short)reader.ReadVarUhShort();
        if (nbCharacBoost < 0)
        {
            throw new System.Exception("Forbidden value (" + nbCharacBoost + ") on element of StatsUpgradeResultMessage.nbCharacBoost.");
        }

    }

}