using Giny.Core.IO.Interfaces;
using Giny.Core.Network.IPC;

namespace Giny.Protocol.IPC.Messages;

public class ResetWorldResultMessage : IPCMessage
{
    public const ushort Id = 19;

    public override ushort MessageId
    {
        get
        {
            return Id;
        }
    }

    public bool success;

    public ResetWorldResultMessage(bool success)
    {
        this.success = success;
    }
    public ResetWorldResultMessage()
    {

    }


    public override void Serialize(IDataWriter writer)
    {
        writer.WriteBoolean(success);
    }

    public override void Deserialize(IDataReader reader)
    {
        this.success = reader.ReadBoolean();
    }
}