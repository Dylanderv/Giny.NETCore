using System.Reflection;

namespace Giny.World.Modules;

public class AssemblyCore
{
    private static IEnumerable<Type> m_types = null;

    public static void OnAssembliesLoaded()
    {
        var assemblyType = Assembly.GetAssembly(typeof(AssemblyCore)).GetTypes();
        var modulesTypes = ModuleManager.Instance.GetModuleTypes();
        m_types = assemblyType.Concat(modulesTypes);
    }
    public static IEnumerable<Type> GetTypes()
    {
        return m_types;
    }
}