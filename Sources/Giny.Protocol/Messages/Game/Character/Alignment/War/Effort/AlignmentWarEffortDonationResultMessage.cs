using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AlignmentWarEffortDonationResultMessage : NetworkMessage
{
    public const ushort Id = 7579;
    public override ushort MessageId => Id;

    public byte result;

    public AlignmentWarEffortDonationResultMessage()
    {
    }
    public AlignmentWarEffortDonationResultMessage(byte result)
    {
        this.result = result;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteByte((byte)result);
    }
    public override void Deserialize(IDataReader reader)
    {
        result = (byte)reader.ReadByte();
    }

}