using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Types;

public class Item
{
    public const ushort Id = 2946;
    public virtual ushort TypeId => Id;


    public Item()
    {
    }
    public virtual void Serialize(IDataWriter writer)
    {
    }
    public virtual void Deserialize(IDataReader reader)
    {
    }


}