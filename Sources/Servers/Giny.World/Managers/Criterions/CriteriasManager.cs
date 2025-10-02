using Giny.Core.DesignPattern;
using Giny.World.Managers.Criterions.Handlers;
using Giny.World.Modules;
using System.Reflection;

namespace Giny.World.Managers.Criterias;

public class CriteriasManager : Singleton<CriteriasManager>
{
    private static readonly Dictionary<string, Type> m_handlers = new Dictionary<string, Type>();

    [StartupInvoke(StartupInvokePriority.FourthPass)]
    public void Intialize()
    {
        foreach (var type in AssemblyCore.GetTypes())
        {
            CriterionHandlerAttribute attribute = type.GetCustomAttribute<CriterionHandlerAttribute>();

            if (attribute != null)
            {
                m_handlers.Add(attribute.Identifier, type);
            }
        }
    }

    public Criterion GetCriteriaHandler(string criteria)
    {
        string identifier = new string(criteria.Take(2).ToArray());

        if (m_handlers.TryGetValue(identifier, out Type? type))
        {
            return (Criterion)Activator.CreateInstance(type, new object[] { criteria });
        }
        else
        {
            return new UnknownCriterion(criteria);
        }
    }


}
public class CriterionHandlerAttribute : Attribute
{
    public string Identifier
    {
        get;
        set;
    }

    public CriterionHandlerAttribute(string indentifier)
    {
        this.Identifier = indentifier;
    }
}