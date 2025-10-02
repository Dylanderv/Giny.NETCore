using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class DebugClearHighlightCellsMessage : NetworkMessage
{
    public const ushort Id = 3788;
    public override ushort MessageId => Id;


    public DebugClearHighlightCellsMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}