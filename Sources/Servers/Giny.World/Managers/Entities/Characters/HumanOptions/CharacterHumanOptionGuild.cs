using Giny.Protocol.Types;

namespace Giny.World.Managers.Entities.Characters.HumanOptions;

public class CharacterHumanOptionGuild : CharacterHumanOption
{
    public CharacterHumanOptionGuild()
    {

    }
    public override HumanOption GetHumanOption(Character character)
    {
        return new HumanOptionGuild()
        {
            guildInformations = character.Guild.GetGuildInformations(),
        };
    }
}