using Giny.Protocol.Enums;

namespace Giny.World.Managers.Fights.Cast;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class SpellEffectHandlerAttribute : Attribute
{
    public EffectsEnum Effect
    {
        get;
        set;
    }

    public SpellEffectHandlerAttribute(EffectsEnum effect)
    {
        this.Effect = effect;
    }

}