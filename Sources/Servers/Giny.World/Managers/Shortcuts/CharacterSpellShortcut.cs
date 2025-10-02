using Giny.Protocol.Types;
using ProtoBuf;

namespace Giny.World.Managers.Shortcuts;

[ProtoContract]
public class CharacterSpellShortcut : CharacterShortcut
{
    [ProtoMember(6)]
    public short SpellId
    {
        get;
        set;
    }
    public CharacterSpellShortcut()
    {
    }
    public CharacterSpellShortcut(byte slotId, short spellId) : base(slotId)
    {
        this.SpellId = spellId;
    }
    public override Shortcut GetShortcut()
    {
        return new ShortcutSpell()
        {
            slot = SlotId,
            spellId = SpellId,
        };
    }
}