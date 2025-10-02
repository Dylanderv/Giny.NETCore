using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Types;

public class SpawnInformation
{
    public const ushort Id = 5624;
    public virtual ushort TypeId => Id;


    public SpawnInformation()
    {
    }
    public virtual void Serialize(IDataWriter writer)
    {
    }
    public virtual void Deserialize(IDataReader reader)
    {
    }


}