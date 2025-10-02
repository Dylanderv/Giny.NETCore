using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ArenaFighterIdleMessage : NetworkMessage
{
    public const ushort Id = 9203;
    public override ushort MessageId => Id;


    public ArenaFighterIdleMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}