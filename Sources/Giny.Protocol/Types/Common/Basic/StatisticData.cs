using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Types;

public class StatisticData
{
    public const ushort Id = 5268;
    public virtual ushort TypeId => Id;


    public StatisticData()
    {
    }
    public virtual void Serialize(IDataWriter writer)
    {
    }
    public virtual void Deserialize(IDataReader reader)
    {
    }


}