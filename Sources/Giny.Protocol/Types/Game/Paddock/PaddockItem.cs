using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Types;

public class PaddockItem : ObjectItemInRolePlay
{
    public new const ushort Id = 5892;
    public override ushort TypeId => Id;

    public ItemDurability durability;

    public PaddockItem()
    {
    }
    public PaddockItem(ItemDurability durability, short cellId, int objectGID)
    {
        this.durability = durability;
        this.cellId = cellId;
        this.objectGID = objectGID;
    }
    public override void Serialize(IDataWriter writer)
    {
        base.Serialize(writer);
        durability.Serialize(writer);
    }
    public override void Deserialize(IDataReader reader)
    {
        base.Deserialize(reader);
        durability = new ItemDurability();
        durability.Deserialize(reader);
    }


}