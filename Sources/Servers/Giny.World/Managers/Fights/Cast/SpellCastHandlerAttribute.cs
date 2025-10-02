namespace Giny.World.Managers.Fights.Cast;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class SpellCastHandlerAttribute : Attribute
{
    public short SpellId
    {
        get;
        set;
    }
    public SpellCastHandlerAttribute(short spellId)
    {
        this.SpellId = spellId;
    }
}