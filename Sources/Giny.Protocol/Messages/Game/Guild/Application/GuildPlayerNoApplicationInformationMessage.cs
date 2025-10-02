using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class GuildPlayerNoApplicationInformationMessage : GuildPlayerApplicationAbstractMessage
{
    public new const ushort Id = 933;
    public override ushort MessageId => Id;


    public GuildPlayerNoApplicationInformationMessage()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }

}