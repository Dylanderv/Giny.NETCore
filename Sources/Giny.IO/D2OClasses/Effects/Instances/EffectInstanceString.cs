using Giny.Core.IO.Interfaces;
using Giny.IO.D2O;

namespace Giny.IO.D2OClasses;

[D2OClass("EffectInstanceString", "")]
public class EffectInstanceString : EffectInstance, IIndexedData
{

    public int Id => throw new NotImplementedException();

    public string text;

    [D2OIgnore]
    public string Text
    {
        get
        {
            return text;
        }
        set
        {
            text = value;
        }
    }

}