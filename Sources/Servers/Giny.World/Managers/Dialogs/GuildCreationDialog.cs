using Giny.Protocol.Enums;
using Giny.Protocol.Messages;
using Giny.World.Managers.Entities.Characters;

namespace Giny.World.Managers.Dialogs;

public class GuildCreationDialog : Dialog
{
    public override DialogTypeEnum DialogType
    {
        get
        {
            return DialogTypeEnum.DIALOG_GUILD_CREATE;
        }
    }

    public GuildCreationDialog(Character character)
        : base(character)
    {

    }
    public override void Open()
    {
        Character.Client.Send(new GuildCreationStartedMessage());
    }
}