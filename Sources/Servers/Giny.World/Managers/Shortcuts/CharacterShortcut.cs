using Giny.Protocol.Types;
using ProtoBuf;

namespace Giny.World.Managers.Shortcuts;

[ProtoContract]
[ProtoInclude(2, typeof(CharacterItemShortcut))]
[ProtoInclude(3, typeof(CharacterItemShortcut))]
[ProtoInclude(4, typeof(CharacterEmoteShortcut))]
[ProtoInclude(5, typeof(CharacterSmileyShortcut))]
[ProtoInclude(6, typeof(CharacterSpellShortcut))]
public abstract class CharacterShortcut
{
    [ProtoMember(1)]
    public byte SlotId
    {
        get;
        set;
    }

    public CharacterShortcut(byte slotId)
    {
        this.SlotId = slotId;
    }
    public CharacterShortcut()
    {

    }
    public abstract Shortcut GetShortcut();
}