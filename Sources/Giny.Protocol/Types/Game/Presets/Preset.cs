using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Types;

public class Preset
{
    public const ushort Id = 1447;
    public virtual ushort TypeId => Id;

    public short id;

    public Preset()
    {
    }
    public Preset(short id)
    {
        this.id = id;
    }
    public virtual void Serialize(IDataWriter writer)
    {
        writer.WriteShort((short)id);
    }
    public virtual void Deserialize(IDataReader reader)
    {
        id = (short)reader.ReadShort();
    }


}