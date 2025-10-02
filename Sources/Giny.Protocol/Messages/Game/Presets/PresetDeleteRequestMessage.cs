using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class PresetDeleteRequestMessage : NetworkMessage
{
    public const ushort Id = 5847;
    public override ushort MessageId => Id;

    public short presetId;

    public PresetDeleteRequestMessage()
    {
    }
    public PresetDeleteRequestMessage(short presetId)
    {
        this.presetId = presetId;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteShort((short)presetId);
    }
    public override void Deserialize(IDataReader reader)
    {
        presetId = (short)reader.ReadShort();
    }

}