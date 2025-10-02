using Giny.Core.Network.Messages;
using Giny.Protocol.Types;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class BreachBonusMessage : NetworkMessage
{
    public const ushort Id = 4966;
    public override ushort MessageId => Id;

    public ObjectEffectInteger bonus;

    public BreachBonusMessage()
    {
    }
    public BreachBonusMessage(ObjectEffectInteger bonus)
    {
        this.bonus = bonus;
    }
    public override void Serialize(IDataWriter writer)
    {
        bonus.Serialize(writer);
    }
    public override void Deserialize(IDataReader reader)
    {
        bonus = new ObjectEffectInteger();
        bonus.Deserialize(reader);
    }

}