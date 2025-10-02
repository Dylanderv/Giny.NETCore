using Giny.IO.D2O;
using Giny.ORM.Attributes;
using Giny.ORM.Interfaces;

namespace Giny.World.Records.Maps;

[D2OClass("MapScrollAction")]
[Table("map_scroll_actions")]
public class MapScrollActionRecord : IRecord
{
    [Container]
    private static Dictionary<long, MapScrollActionRecord> MapScrollActions = new Dictionary<long, MapScrollActionRecord>();

    [Ignore]
    public long Id => MapId;

    [D2OField("id")]
    [Primary]
    public int MapId
    {
        get;
        set;
    }
    [D2OField("rightMapId")]
    public int RightMapId
    {
        get;
        set;
    }
    [D2OField("leftMapId")]
    public int LeftMapId
    {
        get;
        set;
    }
    [D2OField("topMapId")]
    public int TopMapId
    {
        get;
        set;
    }
    [D2OField("bottomMapId")]
    public int BottomMapId
    {
        get;
        set;
    }
    public static MapScrollActionRecord GetMapScrollAction(long mapId)
    {
        return MapScrollActions.ContainsKey(mapId) ? MapScrollActions[mapId] : null;
    }

}