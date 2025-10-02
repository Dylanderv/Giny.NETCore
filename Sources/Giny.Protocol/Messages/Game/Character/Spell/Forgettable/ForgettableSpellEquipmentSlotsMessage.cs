using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ForgettableSpellEquipmentSlotsMessage : NetworkMessage
{
    public const ushort Id = 9647;
    public override ushort MessageId => Id;

    public short quantity;

    public ForgettableSpellEquipmentSlotsMessage()
    {
    }
    public ForgettableSpellEquipmentSlotsMessage(short quantity)
    {
        this.quantity = quantity;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteVarShort((short)quantity);
    }
    public override void Deserialize(IDataReader reader)
    {
        quantity = (short)reader.ReadVarShort();
    }

}