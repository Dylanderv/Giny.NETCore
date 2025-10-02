using Giny.Core.DesignPattern;
using Giny.Core.IO.Configuration;
using Giny.Core.Logging;
using Giny.ORM;
using System.Reflection;

namespace Giny.World.Records;

public class Database : Singleton<Database>
{
    ProgressLogger ProgressLogger = new ProgressLogger();

    [StartupInvoke("Database", StartupInvokePriority.SecondPass)]
    public void InitializeDatabase()
    {
        DatabaseManager.Instance.OnTablesLoadProgress += OnLoadProgress;

        WorldConfig config = ConfigManager<WorldConfig>.Instance;

        DatabaseManager.Instance.Initialize(Assembly.GetExecutingAssembly(), config.SQLHost,
            config.SQLDBName, config.SQLUser, config.SQLPassword);

        DatabaseManager.Instance.LoadTables();

        ProgressLogger.Flush();

        DatabaseManager.Instance.OnTablesLoadProgress -= OnLoadProgress;
    }


    private void OnLoadProgress(string tableName, int currentIndex, int length)
    {
        ProgressLogger.WriteProgressBar(currentIndex, length);
    }
}