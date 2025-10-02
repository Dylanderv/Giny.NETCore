using Giny.Core.IO.Interfaces;
using Giny.Core.Network.IPC;

namespace Giny.Protocol.IPC.Messages;

public class IsIpConnectedRequestMessage : IPCMessage
{
    public const ushort Id = 12;

    public override ushort MessageId => Id;

    public string ip;

    public IsIpConnectedRequestMessage(string ip)
    {
        this.ip = ip;
    }
    public IsIpConnectedRequestMessage()
    {

    }
    public override void Deserialize(IDataReader reader)
    {
        ip = reader.ReadUTF();
    }

    public override void Serialize(IDataWriter writer)
    {
        writer.WriteUTF(ip);
    }
}