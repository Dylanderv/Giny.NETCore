using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class PopupWarningClosedMessage : NetworkMessage
{
    public const ushort Id = 7639;
    public override ushort MessageId => Id;


    public PopupWarningClosedMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}