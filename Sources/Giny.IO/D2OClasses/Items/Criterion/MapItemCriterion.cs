using Giny.Core.IO.Interfaces;
using Giny.IO.D2O;

namespace Giny.IO.D2OClasses;

[D2OClass("MapItemCriterion", "")]
public class MapItemCriterion : ItemCriterion, IIndexedData
{

    public int Id => throw new NotImplementedException();



}