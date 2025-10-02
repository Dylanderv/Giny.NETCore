using Giny.IO.D2O;
using Giny.ORM.Attributes;
using Giny.ORM.Interfaces;

namespace Giny.World.Records.Tinsel;

[D2OClass("Ornament")]
[Table("ornaments")]
public class OrnamentRecord : IRecord
{
    [Container]
    private static Dictionary<long, OrnamentRecord> Ornaments = new Dictionary<long, OrnamentRecord>();

    [Primary]
    [D2OField("id")]
    public long Id
    {
        get;
        set;
    }
    [D2OField("nameId")]
    [I18NField]
    public string Name
    {
        get;
        set;
    }

    public static bool Exists(short id)
    {
        return Ornaments.ContainsKey(id);
    }
}