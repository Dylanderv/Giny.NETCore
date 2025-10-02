using Giny.Protocol.Enums;

namespace Giny.World.Managers.Entities.Characters;

public class CharacterCreationResult
{
    public CharacterCreationResultEnum Result
    {
        get;
        set;
    }
    /// <summary>
    /// Couldnt find this in client
    /// </summary>
    public byte Reason
    {
        get;
        set;
    }

    public CharacterCreationResult(CharacterCreationResultEnum result, byte reason = 0)
    {
        this.Result = result;
        this.Reason = reason;
    }
}