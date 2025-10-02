using Giny.Core.Network.Messages;
using Giny.Protocol.Custom.Enums;
using Giny.Protocol.Messages;
using Giny.World.Network;

namespace Giny.World.Handlers.Roleplay.Spells;

class SpellsHandler
{
    [MessageHandler]
    public static void HandleSpellVariantActivationRequestMessage(SpellVariantActivationRequestMessage message, WorldClient client)
    {
        var spell = client.Character.GetSpellByVariant(message.spellId);

        if (spell != null)
        {
            if (!client.Character.Fighting || client.Account.Role == ServerRoleEnum.Administrator)
            {
                client.Character.SpellShortcutBar.UpdateVariantShortcut(spell.ActiveSpellRecord.Id, spell.ActiveSpellRecord.VariantRecord.Id);
                spell.Variant = !spell.Variant;
                client.Send(new SpellVariantActivationMessage(message.spellId, true));
            }
        }
    }
}