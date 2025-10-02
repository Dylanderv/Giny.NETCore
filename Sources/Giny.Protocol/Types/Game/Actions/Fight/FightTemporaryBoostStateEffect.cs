using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Types;

public class FightTemporaryBoostStateEffect : FightTemporaryBoostEffect
{
    public new const ushort Id = 1864;
    public override ushort TypeId => Id;

    public short stateId;

    public FightTemporaryBoostStateEffect()
    {
    }
    public FightTemporaryBoostStateEffect(short stateId, int uid, double targetId, short turnDuration, byte dispelable, short spellId, int effectId, int parentBoostUid, int delta)
    {
        this.stateId = stateId;
        this.uid = uid;
        this.targetId = targetId;
        this.turnDuration = turnDuration;
        this.dispelable = dispelable;
        this.spellId = spellId;
        this.effectId = effectId;
        this.parentBoostUid = parentBoostUid;
        this.delta = delta;
    }
    public override void Serialize(IDataWriter writer)
    {
        base.Serialize(writer);
        writer.WriteShort((short)stateId);
    }
    public override void Deserialize(IDataReader reader)
    {
        base.Deserialize(reader);
        stateId = (short)reader.ReadShort();
    }


}