using Giny.Core;
using Giny.ProtocolBuilder.Profiles;
using System.Diagnostics;

namespace Giny.ProtocolBuilder;

class Program
{
    static void Main(string[] args)
    {
        Logger.DrawLogo();
        Stopwatch stopwatch = Stopwatch.StartNew();


        BuildEnums();
        //    BuildMessages();
        BuildTypes();
        //  BuildDatacenter();

        Logger.WriteColor1(string.Format("Build finished in {0}s", stopwatch.Elapsed.Seconds));

        Console.ReadLine();
    }

    static void BuildEnums()
    {
        Logger.Write("Building Enums...");
        string path = Path.Combine(Constants.SOURCES_PATH, Constants.ENUMS_PATH);
        EnumProfile @enum = new EnumProfile(path);
        @enum.Generate();
    }

    static void BuildMessages()
    {
        Logger.Write("Building Messages...");
        string path = Path.Combine(Constants.SOURCES_PATH, Constants.MESSAGES_PATH);
        MessageProfile message = new MessageProfile(path);
        message.Generate();

    }
    static void BuildTypes()
    {
        Logger.Write("Building Types...");
        string path = Path.Combine(Constants.SOURCES_PATH, Constants.TYPES_PATH);
        TypeProfile type = new TypeProfile(path);
        type.Generate();
    }
    static void BuildDatacenter()
    {
        Logger.Write("Building Datacenter...");
        string path = Path.Combine(Constants.SOURCES_PATH, Constants.DATACENTER_PATH);
        DatacenterProfile datacenter = new DatacenterProfile(path);
        datacenter.Generate();

    }
}