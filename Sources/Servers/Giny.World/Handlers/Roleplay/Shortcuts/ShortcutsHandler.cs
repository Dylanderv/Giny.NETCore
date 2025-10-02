using Giny.Core.Network.Messages;
using Giny.Protocol.Enums;
using Giny.Protocol.Messages;
using Giny.World.Managers.Shortcuts;
using Giny.World.Network;

namespace Giny.World.Handlers.Roleplay.Shortcuts;

class ShortcutsHandler
{

    [MessageHandler]
    public static void HandleShortcutBarSwap(ShortcutBarSwapRequestMessage message, WorldClient client)
    {
        var bar = client.Character.GetShortcutBar((ShortcutBarEnum)message.barType);
        bar.Swap(message.firstSlot, message.secondSlot);

    }
    [MessageHandler]
    public static void HandleShortcutBarRemove(ShortcutBarRemoveRequestMessage message, WorldClient client)
    {
        var bar = client.Character.GetShortcutBar((ShortcutBarEnum)message.barType);
        bar.RemoveShortcut(message.slot);

    }
    [MessageHandler]
    public static void HandleShortcutBarAdd(ShortcutBarAddRequestMessage message, WorldClient client)
    {
        var bar = client.Character.GetShortcutBar((ShortcutBarEnum)message.barType);

        CharacterShortcut shortcut = ShortcutBar.GetCharacterShortcut(client.Character, message.shortcut);

        if (shortcut != null)
        {
            bar.Add(shortcut);
        }
    }

}