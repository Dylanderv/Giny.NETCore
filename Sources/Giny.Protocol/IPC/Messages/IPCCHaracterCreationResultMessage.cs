using Giny.Core.IO.Interfaces;
using Giny.Core.Network.IPC;

namespace Giny.Protocol.IPC.Messages;

public class IPCCharacterCreationResultMessage : IPCMessage
{
    public static ushort Id = 8;

    public override ushort MessageId
    {
        get
        {
            return Id;
        }
    }
    public bool succes;

    public IPCCharacterCreationResultMessage()
    {

    }

    public IPCCharacterCreationResultMessage(bool succes)
    {
        this.succes = succes;
    }

    public override void Serialize(IDataWriter writer)
    {
        writer.WriteBoolean(succes);
    }

    public override void Deserialize(IDataReader reader)
    {
        this.succes = reader.ReadBoolean();
    }
}