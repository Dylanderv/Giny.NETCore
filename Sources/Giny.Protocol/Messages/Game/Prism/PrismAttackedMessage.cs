using Giny.Core.Network.Messages;
using Giny.Protocol.Types;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class PrismAttackedMessage : NetworkMessage
{
    public const ushort Id = 2689;
    public override ushort MessageId => Id;

    public PrismGeolocalizedInformation prism;

    public PrismAttackedMessage()
    {
    }
    public PrismAttackedMessage(PrismGeolocalizedInformation prism)
    {
        this.prism = prism;
    }
    public override void Serialize(IDataWriter writer)
    {
        prism.Serialize(writer);
    }
    public override void Deserialize(IDataReader reader)
    {
        prism = new PrismGeolocalizedInformation();
        prism.Deserialize(reader);
    }

}