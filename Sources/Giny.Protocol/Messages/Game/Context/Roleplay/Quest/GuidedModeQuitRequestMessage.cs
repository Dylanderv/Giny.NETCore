using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GuidedModeQuitRequestMessage : NetworkMessage
{
    public const ushort Id = 7391;
    public override ushort MessageId => Id;


    public GuidedModeQuitRequestMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}