using Giny.Protocol.Types;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AlliancePartialListMessage : AllianceListMessage
{
    public new const ushort Id = 7536;
    public override ushort MessageId => Id;


    public AlliancePartialListMessage()
    {
    }
    public AlliancePartialListMessage(AllianceFactSheetInformation[] alliances)
    {
        this.alliances = alliances;
    }
    public override void Serialize(IDataWriter writer)
    {
        base.Serialize(writer);
    }
    public override void Deserialize(IDataReader reader)
    {
        base.Deserialize(reader);
    }

}