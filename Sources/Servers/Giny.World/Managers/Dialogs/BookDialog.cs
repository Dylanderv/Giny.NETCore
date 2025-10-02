using Giny.Protocol.Enums;
using Giny.Protocol.Messages;
using Giny.World.Managers.Entities.Characters;

namespace Giny.World.Managers.Dialogs;

public class BookDialog : Dialog
{
    public override DialogTypeEnum DialogType => DialogTypeEnum.DIALOG_BOOK;

    public int DocumentId
    {
        get;
        set;
    }

    public BookDialog(Character character, int documentId)
        : base(character)
    {
        this.DocumentId = documentId;
    }
    public override void Open()
    {
        Character.Client.Send(new DocumentReadingBeginMessage((short)DocumentId));
    }
}