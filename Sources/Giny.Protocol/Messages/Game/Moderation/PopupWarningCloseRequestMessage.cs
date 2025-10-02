using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class PopupWarningCloseRequestMessage : NetworkMessage
{
    public const ushort Id = 2188;
    public override ushort MessageId => Id;


    public PopupWarningCloseRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}