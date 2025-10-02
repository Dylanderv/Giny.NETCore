using Giny.Protocol.Enums;
using Giny.Protocol.Types;
using ProtoBuf;

namespace Giny.World.Managers.Effects;

[ProtoContract]
public class EffectInteger : Effect
{
    [ProtoMember(4)]
    public virtual int Value
    {
        get;
        set;
    }

    public EffectInteger()
    {

    }

    public EffectInteger(EffectsEnum effectsEnum, int value) : base((short)effectsEnum)
    {
        this.Value = value;
    }
    public EffectInteger(short effectId, int value)
        : base(effectId)
    {
        this.Value = value;
    }
    public override ObjectEffect GetObjectEffect()
    {
        return new ObjectEffectInteger()
        {
            actionId = EffectId,
            value = Value,
        };
    }
    public override bool Equals(object obj)
    {
        return obj is EffectInteger ? this.Equals(obj as EffectInteger) : false;
    }
    public bool Equals(EffectInteger effect)
    {
        return this.EffectId == effect.EffectId && effect.Value == this.Value;
    }
    public override object Clone()
    {
        return new EffectInteger(EffectId, Value)
        {
            Delay = Delay,
            Dispellable = Dispellable,
            Duration = Duration,
            Group = Group,
            Modificator = Modificator,
            TargetMask = TargetMask,
            TargetId = TargetId,
            Trigger = Trigger,
            RawTriggers = RawTriggers,
            Order = Order,
            Random = Random,
            RawZone = RawZone,
        };
    }

}