using Giny.ORM.Attributes;
using Giny.ORM.Interfaces;

namespace Giny.World.Records.Items;

[Table("initial_items")]
public class InitialItemRecord : IRecord
{
    [Container]
    private static Dictionary<long, InitialItemRecord> InitialItems = new Dictionary<long, InitialItemRecord>();

    [Ignore]
    long IRecord.Id => GId;


    [Primary]
    public int GId
    {
        get;
        set;
    }

    public int Quantity
    {
        get;
        set;
    }

    public static List<InitialItemRecord> GetInitialItemRecords()
    {
        return InitialItems.Values.ToList();
    }
}