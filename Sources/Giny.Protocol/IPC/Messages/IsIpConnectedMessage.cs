using Giny.Core.IO.Interfaces;
using Giny.Core.Network.IPC;

namespace Giny.Protocol.IPC.Messages;

public class IsIpConnectedMessage : IPCMessage
{
    public const ushort Id = 13;

    public override ushort MessageId => Id;

    public bool connected;

    public IsIpConnectedMessage(bool connected)
    {
        this.connected = connected;
    }
    public IsIpConnectedMessage()
    {

    }

    public override void Deserialize(IDataReader reader)
    {
        connected = reader.ReadBoolean();
    }

    public override void Serialize(IDataWriter writer)
    {
        writer.WriteBoolean(connected);
    }
}