using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Types;

public class GameRolePlayNamedActorInformations : GameRolePlayActorInformations
{
    public new const ushort Id = 594;
    public override ushort TypeId => Id;

    public string name;

    public GameRolePlayNamedActorInformations()
    {
    }
    public GameRolePlayNamedActorInformations(string name, double contextualId, EntityDispositionInformations disposition, EntityLook look)
    {
        this.name = name;
        this.contextualId = contextualId;
        this.disposition = disposition;
        this.look = look;
    }
    public override void Serialize(IDataWriter writer)
    {
        base.Serialize(writer);
        writer.WriteUTF((string)name);
    }
    public override void Deserialize(IDataReader reader)
    {
        base.Deserialize(reader);
        name = (string)reader.ReadUTF();
    }


}