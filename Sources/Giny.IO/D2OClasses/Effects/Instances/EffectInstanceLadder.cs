using Giny.Core.IO.Interfaces;
using Giny.IO.D2O;

namespace Giny.IO.D2OClasses;

[D2OClass("EffectInstanceLadder", "")]
public class EffectInstanceLadder : EffectInstanceCreature, IIndexedData
{

    public int Id => throw new NotImplementedException();

    public uint monsterCount;

    [D2OIgnore]
    public uint MonsterCount
    {
        get
        {
            return monsterCount;
        }
        set
        {
            monsterCount = value;
        }
    }

}