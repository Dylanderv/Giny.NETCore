using Giny.Core.Network.Messages;
using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class RecycleResultMessage : NetworkMessage
{
    public const ushort Id = 913;
    public override ushort MessageId => Id;

    public int nuggetsForPrism;
    public int nuggetsForPlayer;

    public RecycleResultMessage()
    {
    }
    public RecycleResultMessage(int nuggetsForPrism, int nuggetsForPlayer)
    {
        this.nuggetsForPrism = nuggetsForPrism;
        this.nuggetsForPlayer = nuggetsForPlayer;
    }
    public override void Serialize(IDataWriter writer)
    {
        if (nuggetsForPrism < 0)
        {
            throw new System.Exception("Forbidden value (" + nuggetsForPrism + ") on element nuggetsForPrism.");
        }

        writer.WriteVarInt((int)nuggetsForPrism);
        if (nuggetsForPlayer < 0)
        {
            throw new System.Exception("Forbidden value (" + nuggetsForPlayer + ") on element nuggetsForPlayer.");
        }

        writer.WriteVarInt((int)nuggetsForPlayer);
    }
    public override void Deserialize(IDataReader reader)
    {
        nuggetsForPrism = (int)reader.ReadVarUhInt();
        if (nuggetsForPrism < 0)
        {
            throw new System.Exception("Forbidden value (" + nuggetsForPrism + ") on element of RecycleResultMessage.nuggetsForPrism.");
        }

        nuggetsForPlayer = (int)reader.ReadVarUhInt();
        if (nuggetsForPlayer < 0)
        {
            throw new System.Exception("Forbidden value (" + nuggetsForPlayer + ") on element of RecycleResultMessage.nuggetsForPlayer.");
        }

    }

}