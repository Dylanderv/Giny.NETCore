using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Types;

public class AbstractSocialGroupInfos
{
    public const ushort Id = 9344;
    public virtual ushort TypeId => Id;


    public AbstractSocialGroupInfos()
    {
    }
    public virtual void Serialize(IDataWriter writer)
    {
    }
    public virtual void Deserialize(IDataReader reader)
    {
    }


}