using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Types;

public class TaxCollectorComplementaryInformations
{
    public const ushort Id = 875;
    public virtual ushort TypeId => Id;


    public TaxCollectorComplementaryInformations()
    {
    }
    public virtual void Serialize(IDataWriter writer)
    {
    }
    public virtual void Deserialize(IDataReader reader)
    {
    }


}