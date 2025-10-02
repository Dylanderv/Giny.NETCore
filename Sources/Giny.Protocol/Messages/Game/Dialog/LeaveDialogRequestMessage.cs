using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class LeaveDialogRequestMessage : NetworkMessage
{
    public const ushort Id = 9511;
    public override ushort MessageId => Id;


    public LeaveDialogRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}