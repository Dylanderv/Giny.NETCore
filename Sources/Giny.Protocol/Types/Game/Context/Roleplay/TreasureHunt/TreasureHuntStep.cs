using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Types;

public class TreasureHuntStep
{
    public const ushort Id = 4064;
    public virtual ushort TypeId => Id;


    public TreasureHuntStep()
    {
    }
    public virtual void Serialize(IDataWriter writer)
    {
    }
    public virtual void Deserialize(IDataReader reader)
    {
    }


}