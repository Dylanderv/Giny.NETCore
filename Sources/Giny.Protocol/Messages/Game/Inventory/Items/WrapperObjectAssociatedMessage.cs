using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class WrapperObjectAssociatedMessage : SymbioticObjectAssociatedMessage
{
    public new const ushort Id = 7212;
    public override ushort MessageId => Id;


    public WrapperObjectAssociatedMessage()
    {
    }
    public WrapperObjectAssociatedMessage(int hostUID)
    {
        this.hostUID = hostUID;
    }
    public override void Serialize(IDataWriter writer)
    {
        base.Serialize(writer);
    }
    public override void Deserialize(IDataReader reader)
    {
        base.Deserialize(reader);
    }

}