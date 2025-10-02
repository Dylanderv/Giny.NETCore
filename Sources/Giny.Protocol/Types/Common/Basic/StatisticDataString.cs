using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Types;

public class StatisticDataString : StatisticData
{
    public new const ushort Id = 2561;
    public override ushort TypeId => Id;

    public string value;

    public StatisticDataString()
    {
    }
    public StatisticDataString(string value)
    {
        this.value = value;
    }
    public override void Serialize(IDataWriter writer)
    {
        base.Serialize(writer);
        writer.WriteUTF((string)value);
    }
    public override void Deserialize(IDataReader reader)
    {
        base.Deserialize(reader);
        value = (string)reader.ReadUTF();
    }


}