using Giny.World.Managers.Criterias;
using Giny.World.Network;

namespace Giny.World.Managers.Criterions.Handlers;

[CriterionHandler("Pw")]
public class HasGuildCriterion : Criterion
{
    public HasGuildCriterion(string criteriaFull) : base(criteriaFull)
    {
    }

    public override bool Eval(WorldClient client)
    {
        return client.Character.HasGuild;
    }
}
[CriterionHandler("Py")]
public class GuildLevelCriterion : Criterion
{
    public GuildLevelCriterion(string criteriaFull) : base(criteriaFull)
    {
    }

    public override bool Eval(WorldClient client)
    {
        if (!client.Character.HasGuild)
        {
            return false;
        }
        return ArithmeticEval(client.Character.Guild.Level);
    }
}