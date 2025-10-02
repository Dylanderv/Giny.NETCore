using Giny.Core.IO.Interfaces;
using Giny.IO.D2O;

namespace Giny.IO.D2OClasses;

[D2OClass("AllianceRankNameSuggestion", "")]
public class AllianceRankNameSuggestion : IDataObject, IIndexedData
{
    public const string MODULE = "AllianceRankNameSuggestions";

    public int Id => throw new NotImplementedException();

    public string uiKey;

    [D2OIgnore]
    public string UiKey
    {
        get
        {
            return uiKey;
        }
        set
        {
            uiKey = value;
        }
    }

}