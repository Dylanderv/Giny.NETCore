using Giny.Core.DesignPattern;
using Giny.Protocol.Custom.Enums;
using Giny.World.Managers.Entities.Characters;

namespace Giny.World.Managers.Formulas;

public class StatsFormulas : Singleton<StatsFormulas>
{
    public int TotalWeight(Character character)
    {
        return 1000 + (character.Record.Stats.Strength.Total() * 5) + character.Record.Stats[CharacteristicEnum.WEIGHT].Total();
    }
}