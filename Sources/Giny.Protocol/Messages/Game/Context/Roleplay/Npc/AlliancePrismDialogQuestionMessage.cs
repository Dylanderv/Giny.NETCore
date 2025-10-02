using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AlliancePrismDialogQuestionMessage : NetworkMessage
{
    public const ushort Id = 8353;
    public override ushort MessageId => Id;


    public AlliancePrismDialogQuestionMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}