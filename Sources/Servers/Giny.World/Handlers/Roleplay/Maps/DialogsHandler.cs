using Giny.Core.Network.Messages;
using Giny.Protocol.Messages;
using Giny.World.Network;

namespace Giny.World.Handlers.Roleplay.Maps;

class DialogsHandler
{
    [MessageHandler]
    public static void HandleLeaveDialogRequest(LeaveDialogRequestMessage message, WorldClient client)
    {
        if (client.Character.IsInDialog())
        {
            client.Send(new LeaveDialogMessage((byte)client.Character.Dialog.DialogType));
            client.Character.LeaveDialog();
        }

        if (client.Character.IsInRequest())
        {
            client.Character.RequestBox.Cancel();
        }
    }
}