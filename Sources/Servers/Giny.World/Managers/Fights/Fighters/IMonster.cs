using Giny.World.Records.Monsters;

namespace Giny.World.Managers.Fights.Fighters;

public interface IMonster
{
    public MonsterGrade Grade
    {
        get;
    }
    public MonsterRecord Record
    {
        get;
    }
}