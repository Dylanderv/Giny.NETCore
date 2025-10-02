using Giny.Core;
using Giny.Core.DesignPattern;
using Giny.Core.IO.Configuration;

namespace Giny.Auth;

public class AuthConfig : IConfigFile
{

    public string Host
    {
        get;
        set;
    } = "127.0.0.1";

    public int Port
    {
        get;
        set;
    } = 443;

    public string SQLHost
    {
        get;
        set;
    } = "127.0.0.1";
    public string SQLUser
    {
        get;
        set;
    } = "root";
    public string SQLPassword
    {
        get;
        set;
    } = string.Empty;

    public string SQLDBName
    {
        get;
        set;
    } = "giny_auth";

    public string IPCHost
    {
        get;
        set;
    } = "127.0.0.1";
    public int IPCPort
    {
        get;
        set;
    } = 800;
    public string APIHost
    {
        get;
        set;
    } = "127.0.0.1";
    public int APIPort
    {
        get;
        set;
    } = 9001;

    public void OnCreated()
    {
        Logger.Write("Configuration file created !");

    }

    public void OnLoaded()
    {
        Logger.Write($"Configuration loaded");
    }


    [StartupInvoke("Configuration", StartupInvokePriority.Initial)]
    public static void Initialize()
    {
        ConfigManager<AuthConfig>.Load("config.json");
    }


}