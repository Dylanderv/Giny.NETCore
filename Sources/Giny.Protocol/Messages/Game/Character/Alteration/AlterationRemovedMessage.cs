using Giny.Core.Network.Messages;
using Giny.Protocol.Types;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AlterationRemovedMessage : NetworkMessage
{
    public const ushort Id = 660;
    public override ushort MessageId => Id;

    public AlterationInfo alteration;

    public AlterationRemovedMessage()
    {
    }
    public AlterationRemovedMessage(AlterationInfo alteration)
    {
        this.alteration = alteration;
    }
    public override void Serialize(IDataWriter writer)
    {
        alteration.Serialize(writer);
    }
    public override void Deserialize(IDataReader reader)
    {
        alteration = new AlterationInfo();
        alteration.Deserialize(reader);
    }

}