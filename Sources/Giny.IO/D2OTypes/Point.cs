using Giny.Core.IO.Interfaces;
using Giny.IO.D2O;

namespace Giny.IO.D2OTypes;

/// <summary>
/// Manually dumped.
/// </summary>
[D2OClass("Point", "flash.geom")]
public class Point : IDataObject
{
    public int x;
    public int y;
    public double length;
}