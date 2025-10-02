namespace Giny.Core.Network.IPC;

public interface IMessageRequest
{
    void ProcessMessage(IPCMessage message);
}