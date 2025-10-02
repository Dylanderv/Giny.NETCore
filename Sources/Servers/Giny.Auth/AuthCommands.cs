using Giny.Core.Commands;
using Giny.Core;

namespace Giny.Auth;

public class AuthCommands
{
    [ConsoleCommand("clear")]
    public static void ClearCommand()
    {
        Console.Clear();
        Logger.DrawLogo();
    }
}