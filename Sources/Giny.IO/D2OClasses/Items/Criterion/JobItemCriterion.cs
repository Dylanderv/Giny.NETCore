using Giny.Core.IO.Interfaces;
using Giny.IO.D2O;

namespace Giny.IO.D2OClasses;

[D2OClass("JobItemCriterion", "")]
public class JobItemCriterion : ItemCriterion, IIndexedData
{

    public int Id => throw new NotImplementedException();



}