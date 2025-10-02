using Giny.ORM.Attributes;
using Giny.ORM.Interfaces;
using Giny.Protocol.Custom.Enums;

namespace Giny.World.Records.Npcs;

[Table("npc_actions")]
public class NpcActionRecord : IRecord
{
    [Container]
    private static Dictionary<long, NpcActionRecord> NpcsActions = new Dictionary<long, NpcActionRecord>();

    [Primary]
    public long Id
    {
        get;
        set;
    }
    public long NpcSpawnId
    {
        get;
        set;
    }
    public NpcActionsEnum Action
    {
        get;
        set;
    }
    [Update]
    [TypeOverride("mediumtext")]
    public string Param1
    {
        get;
        set;
    }
    [Update]
    [TypeOverride("mediumtext")]
    public string Param2
    {
        get;
        set;
    }
    [Update]
    [TypeOverride("mediumtext")]
    public string Param3
    {
        get;
        set;
    }

    [Update]
    [TypeOverride("mediumtext")]
    public string Criteria
    {
        get;
        set;
    }

    public static IEnumerable<NpcActionRecord> GetNpcActions(long npcSpawnId)
    {
        return NpcsActions.Values.Where(x => x.NpcSpawnId == npcSpawnId);
    }

    public static long PopNextId()
    {
        if (NpcsActions.Count == 0)
        {
            return 1;
        }
        return NpcsActions.Keys.OrderByDescending(x => x).First() + 1;
    }

    public override string ToString()
    {
        return Action.ToString();
    }
}