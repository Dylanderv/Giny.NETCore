using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Types;

public class AbstractPlayerSearchInformation
{
    public const ushort Id = 2301;
    public virtual ushort TypeId => Id;


    public AbstractPlayerSearchInformation()
    {
    }
    public virtual void Serialize(IDataWriter writer)
    {
    }
    public virtual void Deserialize(IDataReader reader)
    {
    }


}