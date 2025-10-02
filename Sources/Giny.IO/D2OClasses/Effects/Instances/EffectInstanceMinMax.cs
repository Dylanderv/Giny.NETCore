using Giny.Core.IO.Interfaces;
using Giny.IO.D2O;

namespace Giny.IO.D2OClasses;

[D2OClass("EffectInstanceMinMax", "")]
public class EffectInstanceMinMax : EffectInstance, IIndexedData
{

    public int Id => throw new NotImplementedException();

    public uint min;
    public uint max;

    [D2OIgnore]
    public uint Min
    {
        get
        {
            return min;
        }
        set
        {
            min = value;
        }
    }
    [D2OIgnore]
    public uint Max
    {
        get
        {
            return max;
        }
        set
        {
            max = value;
        }
    }

}