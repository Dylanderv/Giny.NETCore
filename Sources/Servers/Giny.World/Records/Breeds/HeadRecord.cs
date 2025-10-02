using Giny.IO.D2O;
using Giny.ORM.Attributes;
using Giny.ORM.Interfaces;

namespace Giny.World.Records.Breeds;

[D2OClass("Head")]
[Table("heads")]
public class HeadRecord : IRecord
{
    [Container]
    private static readonly Dictionary<long, HeadRecord> Heads = new Dictionary<long, HeadRecord>();

    [D2OField("id")]
    [Primary]
    public long Id
    {
        get;
        set;
    }
    [D2OField("skins")]
    public short SkinId
    {
        get;
        set;
    }

    public static short GetSkinId(short cosmeticId)
    {
        return Heads[cosmeticId].SkinId;
    }
}