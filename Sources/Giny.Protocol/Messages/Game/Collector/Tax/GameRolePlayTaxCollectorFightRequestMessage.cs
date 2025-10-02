using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GameRolePlayTaxCollectorFightRequestMessage : NetworkMessage
{
    public const ushort Id = 5322;
    public override ushort MessageId => Id;


    public GameRolePlayTaxCollectorFightRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}