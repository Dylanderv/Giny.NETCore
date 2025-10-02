using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class LockableChangeCodeMessage : NetworkMessage
{
    public const ushort Id = 4181;
    public override ushort MessageId => Id;

    public string code;

    public LockableChangeCodeMessage()
    {
    }
    public LockableChangeCodeMessage(string code)
    {
        this.code = code;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteUTF((string)code);
    }
    public override void Deserialize(IDataReader reader)
    {
        code = (string)reader.ReadUTF();
    }

}