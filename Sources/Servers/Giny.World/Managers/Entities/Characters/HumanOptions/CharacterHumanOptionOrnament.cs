using Giny.Protocol.Types;

namespace Giny.World.Managers.Entities.Characters.HumanOptions;

public class CharacterHumanOptionOrnament : CharacterHumanOption
{
    public short OrnamentId
    {
        get;
        set;
    }
    public CharacterHumanOptionOrnament(short ornamentId)
    {
        this.OrnamentId = ornamentId;
    }
    public CharacterHumanOptionOrnament()
    {

    }
    public override HumanOption GetHumanOption(Character character)
    {
        return new HumanOptionOrnament()
        {
            ornamentId = OrnamentId,
            ladderPosition = 2,
            leagueId = 0,
            level = character.Level,
        };
    }
}