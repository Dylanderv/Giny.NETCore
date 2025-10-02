using Giny.Protocol.Types;

namespace Giny.World.Managers.Entities.Characters.HumanOptions;

public abstract class CharacterHumanOption
{
    public abstract HumanOption GetHumanOption(Character character);
}