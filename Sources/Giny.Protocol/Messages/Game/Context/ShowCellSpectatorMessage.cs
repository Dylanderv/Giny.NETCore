using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Messages;

public class ShowCellSpectatorMessage : ShowCellMessage
{
    public new const ushort Id = 7844;
    public override ushort MessageId => Id;

    public string playerName;

    public ShowCellSpectatorMessage()
    {
    }
    public ShowCellSpectatorMessage(string playerName, double sourceId, short cellId)
    {
        this.playerName = playerName;
        this.sourceId = sourceId;
        this.cellId = cellId;
    }
    public override void Serialize(IDataWriter writer)
    {
        base.Serialize(writer);
        writer.WriteUTF((string)playerName);
    }
    public override void Deserialize(IDataReader reader)
    {
        base.Deserialize(reader);
        playerName = (string)reader.ReadUTF();
    }

}