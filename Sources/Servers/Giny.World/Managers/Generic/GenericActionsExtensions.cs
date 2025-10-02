namespace Giny.World.Managers.Generic;

public static class GenericActionsExtensions
{
    public static List<short> GetQuestIds<T>(this IEnumerable<T> actions) where T : IGenericAction
    {
        return actions.Where(x => x.ActionIdentifier == GenericActionEnum.StartQuest).Select(x => short.Parse(x.Param1)).ToList();
    }
}