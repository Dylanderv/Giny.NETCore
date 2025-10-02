using Giny.Core.IO.Interfaces;
using Giny.Core.Network.IPC;

namespace Giny.Protocol.IPC.Messages;

public class ResetWorldRequestMessage : IPCMessage
{
    public const ushort Id = 16;

    public override ushort MessageId
    {
        get
        {
            return Id;
        }
    }

    public ResetWorldRequestMessage()
    {

    }


    public override void Serialize(IDataWriter writer)
    {
          
    }

    public override void Deserialize(IDataReader reader)
    {
           
    }
}