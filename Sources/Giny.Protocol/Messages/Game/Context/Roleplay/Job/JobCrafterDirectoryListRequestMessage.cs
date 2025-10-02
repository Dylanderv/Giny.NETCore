using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class JobCrafterDirectoryListRequestMessage : NetworkMessage
{
    public const ushort Id = 5761;
    public override ushort MessageId => Id;

    public byte jobId;

    public JobCrafterDirectoryListRequestMessage()
    {
    }
    public JobCrafterDirectoryListRequestMessage(byte jobId)
    {
        this.jobId = jobId;
    }
    public override void Serialize(IDataWriter writer)
    {
        if (jobId < 0)
        {
            throw new System.Exception("Forbidden value (" + jobId + ") on element jobId.");
        }

        writer.WriteByte((byte)jobId);
    }
    public override void Deserialize(IDataReader reader)
    {
        jobId = (byte)reader.ReadByte();
        if (jobId < 0)
        {
            throw new System.Exception("Forbidden value (" + jobId + ") on element of JobCrafterDirectoryListRequestMessage.jobId.");
        }

    }

}