using Giny.Core.IO.Interfaces;
using Giny.IO.D2O;

namespace Giny.IO.D2OClasses;

[D2OClass("QuestBonus", "")]
public class QuestBonus : Bonus, IIndexedData
{

    public int Id => throw new NotImplementedException();



}