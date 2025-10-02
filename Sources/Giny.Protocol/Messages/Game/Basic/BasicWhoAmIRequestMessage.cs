using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class BasicWhoAmIRequestMessage : NetworkMessage
{
    public const ushort Id = 9342;
    public override ushort MessageId => Id;

    public bool verbose;

    public BasicWhoAmIRequestMessage()
    {
    }
    public BasicWhoAmIRequestMessage(bool verbose)
    {
        this.verbose = verbose;
    }
    public override void Serialize(IDataWriter writer)
    {
        writer.WriteBoolean((bool)verbose);
    }
    public override void Deserialize(IDataReader reader)
    {
        verbose = (bool)reader.ReadBoolean();
    }

}