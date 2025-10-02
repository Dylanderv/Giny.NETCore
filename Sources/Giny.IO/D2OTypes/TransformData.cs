using Giny.Core.IO.Interfaces;
using Giny.IO.D2O;

namespace Giny.IO.D2OTypes;

/// <summary>
/// Manually dumped.
/// </summary>
[D2OClass("TransformData", "com.ankamagames.tiphon.types")]
public class TransformData : IDataObject
{
    public string overrideClip;
    public string originalClip;
    public int x;
    public int y;
    public int scaleX;
    public int scaleY;
    public int rotation;
}