using Giny.Core.IO;
using Giny.Zaap.Network;

namespace Giny.Zaap.Protocol;

public abstract class ZaapMessage
{
        
    public abstract void Serialize(TProtocol protocol, BigEndianWriter writer);
    public abstract void Deserialize(TProtocol protocol, BigEndianReader reader);

        
}