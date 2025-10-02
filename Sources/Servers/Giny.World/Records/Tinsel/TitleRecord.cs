using Giny.IO.D2O;
using Giny.ORM.Attributes;
using Giny.ORM.Interfaces;

namespace Giny.World.Records.Tinsel;

[D2OClass("Title")]
[Table("titles")]
public class TitleRecord : IRecord
{
    [Container]
    private static Dictionary<long, TitleRecord> Titles = new Dictionary<long, TitleRecord>();

    [Primary]
    [D2OField("id")]
    public long Id
    {
        get;
        set;
    }
    [D2OField("nameMaleId")]
    [I18NField]
    public string Name
    {
        get;
        set;
    }

    public static bool Exists(short id)
    {
        return Titles.ContainsKey(id);
    }
}