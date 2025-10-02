using Giny.World.Managers.Entities.Characters;

namespace Giny.World.Api;

public class CharacterEventApi
{
    public static event Action<Character> OnHumanOptionsCreated;

    public static void HumanOptionsCreated(Character character)
    {
        OnHumanOptionsCreated?.Invoke(character);
    }
}