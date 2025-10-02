using Giny.Core.IO.Interfaces;
using Giny.Core.Network.Messages;

namespace Giny.Core.Network.IPC;

public abstract class IPCMessage  : NetworkMessage
{
    public short requestId;
    public bool authSide;

    public IPCMessage()
    {
        this.requestId = -1;
    }

    public override void Pack(IDataWriter writer)
    {
        base.Pack(writer);
        writer.WriteShort(requestId);
        writer.WriteBoolean(authSide);

    }
    public override void Unpack(IDataReader reader)
    {
        base.Unpack(reader);
        this.requestId = reader.ReadShort();
        this.authSide = reader.ReadBoolean();
    }

}