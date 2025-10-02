using Giny.Core.IO.Interfaces;
using Giny.IO.D2O;

namespace Giny.IO.D2OClasses;

[D2OClass("MonsterBonus", "")]
public class MonsterBonus : MonsterLightBonus, IIndexedData
{

    public int Id => throw new NotImplementedException();



}