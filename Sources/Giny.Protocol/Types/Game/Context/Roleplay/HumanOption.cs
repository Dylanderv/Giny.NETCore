using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Types;

public class HumanOption
{
    public const ushort Id = 2920;
    public virtual ushort TypeId => Id;


    public HumanOption()
    {
    }
    public virtual void Serialize(IDataWriter writer)
    {
    }
    public virtual void Deserialize(IDataReader reader)
    {
    }


}