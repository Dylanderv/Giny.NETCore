using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class PaddockToSellListRequestMessage : NetworkMessage
{
    public const ushort Id = 9694;
    public override ushort MessageId => Id;

    public short pageIndex;

    public PaddockToSellListRequestMessage()
    {
    }
    public PaddockToSellListRequestMessage(short pageIndex)
    {
        this.pageIndex = pageIndex;
    }
    public override void Serialize(IDataWriter writer)
    {
        if (pageIndex < 0)
        {
            throw new System.Exception("Forbidden value (" + pageIndex + ") on element pageIndex.");
        }

        writer.WriteVarShort((short)pageIndex);
    }
    public override void Deserialize(IDataReader reader)
    {
        pageIndex = (short)reader.ReadVarUhShort();
        if (pageIndex < 0)
        {
            throw new System.Exception("Forbidden value (" + pageIndex + ") on element of PaddockToSellListRequestMessage.pageIndex.");
        }

    }

}