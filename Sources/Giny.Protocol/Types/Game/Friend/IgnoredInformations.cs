using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Types;

public class IgnoredInformations : AbstractContactInformations
{
    public new const ushort Id = 4916;
    public override ushort TypeId => Id;


    public IgnoredInformations()
    {
    }
    public IgnoredInformations(int accountId, AccountTagInformation accountTag)
    {
        this.accountId = accountId;
        this.accountTag = accountTag;
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