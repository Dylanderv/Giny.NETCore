using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Types;

public class ShortcutObject : Shortcut
{
    public new const ushort Id = 7459;
    public override ushort TypeId => Id;


    public ShortcutObject()
    {
    }
    public ShortcutObject(byte slot)
    {
        this.slot = slot;
    }
    public override void Serialize(IDataWriter writer)
    {
        base.Serialize(writer);
    }
    public override void Deserialize(IDataReader reader)
    {
        base.Deserialize(reader);
    }


}