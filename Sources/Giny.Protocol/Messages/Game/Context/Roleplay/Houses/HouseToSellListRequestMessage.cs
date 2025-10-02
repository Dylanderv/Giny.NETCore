using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class HouseToSellListRequestMessage : NetworkMessage
{
    public const ushort Id = 5271;
    public override ushort MessageId => Id;

    public short pageIndex;

    public HouseToSellListRequestMessage()
    {
    }
    public HouseToSellListRequestMessage(short pageIndex)
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
            throw new System.Exception("Forbidden value (" + pageIndex + ") on element of HouseToSellListRequestMessage.pageIndex.");
        }

    }

}