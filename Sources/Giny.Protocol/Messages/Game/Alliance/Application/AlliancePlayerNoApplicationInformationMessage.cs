using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class AlliancePlayerNoApplicationInformationMessage : AlliancePlayerApplicationAbstractMessage
{
    public new const ushort Id = 971;
    public override ushort MessageId => Id;


    public AlliancePlayerNoApplicationInformationMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}