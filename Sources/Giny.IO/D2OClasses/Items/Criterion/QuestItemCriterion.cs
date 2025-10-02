using Giny.Core.IO.Interfaces;
using Giny.IO.D2O;

namespace Giny.IO.D2OClasses;

[D2OClass("QuestItemCriterion", "")]
public class QuestItemCriterion : ItemCriterion, IIndexedData
{

    public int Id => throw new NotImplementedException();



}