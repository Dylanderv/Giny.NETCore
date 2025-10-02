using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Types;

public class GuildUnlockNewTabActivity : GuildLogbookEntryBasicInformation
{
    public new const ushort Id = 2924;
    public override ushort TypeId => Id;


    public GuildUnlockNewTabActivity()
    {
    }
    public GuildUnlockNewTabActivity(int id, double date)
    {
        this.id = id;
        this.date = date;
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