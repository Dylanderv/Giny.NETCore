using ProtoBuf;

namespace Giny.World.Records.Maps;

[ProtoContract]
public class PointRecord
{
    [ProtoMember(1)]
    public int X
    {
        get;
        set;
    }
    [ProtoMember(2)]
    public int Y
    {
        get;
        set;
    }

    public PointRecord()
    {

    }

    public PointRecord(int x, int y)
    {
        X = x;
        Y = y;
    }
}