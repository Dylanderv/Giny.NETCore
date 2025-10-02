using ProtoBuf;

namespace Giny.Core.IO;

public static class Protobuf
{
    public static byte[] Serialize(object record)
    {
        if (null == record) throw new Exception();

        using (var stream = new MemoryStream())
        {
            Serializer.Serialize(stream, record);
            return stream.ToArray();
        }
    }
    public static T Deserialize<T>(byte[] buffer) where T : class
    {
        using (var stream = new MemoryStream(buffer))
        {
            return Serializer.Deserialize<T>(stream);
        }
    }
    public static object Deserialize(byte[] buffer, Type type)
    {
        using (var stream = new MemoryStream(buffer))
        {
            return Serializer.Deserialize(type, stream);
        }
    }
}