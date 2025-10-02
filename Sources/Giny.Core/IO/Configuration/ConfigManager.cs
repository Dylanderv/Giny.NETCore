using Giny.Core.DesignPattern;

namespace Giny.Core.IO.Configuration;

public class ConfigManager<T> : Singleton<ConfigManager<T>> where T : class, IConfigFile
{
    public static T Instance
    {
        get;
        set;
    }

    public static void Load(string filepath)
    {
        if (File.Exists(filepath))
        {
            try
            {

                Instance = Json.Deserialize<T>(File.ReadAllText(filepath));
                Instance.OnLoaded();

            }
            catch
            {
                Logger.Write("Unable to load configuration. Recreating it", Channels.Warning);
                CreateConfig(filepath);
            }

        }
        else
        {
            CreateConfig(filepath);
        }
    }

    private static void CreateConfig(string filepath)
    {
        var result = (IConfigFile)Activator.CreateInstance(typeof(T))!;

        result.OnCreated();

        Instance = (T)result;

        Save(filepath);


    }
    public static void Save(string filepath)
    {
        File.WriteAllText(filepath, Json.Serialize(Instance));
    }
}