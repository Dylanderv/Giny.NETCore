using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class BreachRoomLockedMessage : NetworkMessage
{
    public const ushort Id = 3579;
    public override ushort MessageId => Id;


    public BreachRoomLockedMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}