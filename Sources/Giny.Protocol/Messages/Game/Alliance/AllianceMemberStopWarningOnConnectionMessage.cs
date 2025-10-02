using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AllianceMemberStopWarningOnConnectionMessage : NetworkMessage
{
    public const ushort Id = 9966;
    public override ushort MessageId => Id;


    public AllianceMemberStopWarningOnConnectionMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}