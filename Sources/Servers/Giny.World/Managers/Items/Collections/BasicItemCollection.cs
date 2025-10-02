using Giny.World.Records.Items;

namespace Giny.World.Managers.Items.Collections;

public class BasicItemCollection : ItemCollection<CharacterItemRecord>
{
    public BasicItemCollection()
    {
    }

    public BasicItemCollection(IEnumerable<CharacterItemRecord> items) : base(items)
    {
    }
}