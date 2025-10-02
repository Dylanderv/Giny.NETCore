namespace Giny.Zaap.Accounts;

public interface IAccountProvider
{
    public WebAccount GetAccount(int instanceId);
}