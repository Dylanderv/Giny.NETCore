using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class SymbioticObjectErrorMessage : ObjectErrorMessage
{
    public new const ushort Id = 7722;
    public override ushort MessageId => Id;

    public byte errorCode;

    public SymbioticObjectErrorMessage()
    {
    }
    public SymbioticObjectErrorMessage(byte errorCode, byte reason)
    {
        this.errorCode = errorCode;
        this.reason = reason;
    }
    public override void Serialize(IDataWriter writer)
    {
        base.Serialize(writer);
        writer.WriteByte((byte)errorCode);
    }
    public override void Deserialize(IDataReader reader)
    {
        base.Deserialize(reader);
        errorCode = (byte)reader.ReadByte();
    }

}