using Giny.Core.IO.Interfaces;
using Giny.IO.D2O;

namespace Giny.IO.D2OTypes;

/// <summary>
/// Manually dumped.
/// </summary>
[D2OClass("Rectangle", "flash.geom")]
public class Rectangle : IDataObject
{
    public int x;
    public int y;
    public int width;
    public int height;
}