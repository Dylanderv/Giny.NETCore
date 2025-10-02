using Giny.Protocol.Enums;
using Giny.World.Managers.Entities.Characters;
using Giny.World.Records.Items;

namespace Giny.World.Managers.Shortcuts;

public class GeneralShortcutBar : ShortcutBar
{
    public override ShortcutBarEnum BarEnum => ShortcutBarEnum.GENERAL_SHORTCUT_BAR;

    public GeneralShortcutBar(Character character) : base(character)
    {

    }
    public override List<CharacterShortcut> InitializeShortcuts()
    {
        return Character.Record.Shortcuts.FindAll(x => !(x is CharacterSpellShortcut));
    }

    public void OnItemRemoved(CharacterItemRecord obj)
    {
        var shortcut = GetItemShortcut(obj.UId);

        if (shortcut != null)
        {
            RemoveShortcut(shortcut.SlotId);
        }
    }

    private CharacterItemShortcut GetItemShortcut(int itemUId)
    {
        return Shortcuts.OfType<CharacterItemShortcut>().FirstOrDefault(x => x.ItemUId == itemUId);
    }
}