using Giny.Protocol.Types;

namespace Giny.World.Managers.Effects;

public abstract class EffectCustom : Effect
{
    public const short TextEffectId = 990;

    public EffectCustom()
    {
        this.EffectId = TextEffectId;
    }

    public override ObjectEffect GetObjectEffect()
    {
        return new ObjectEffectString()
        {
            actionId = EffectId,
            value = GetEffectDescription(),
        };
    }

    protected abstract string GetEffectDescription();
}