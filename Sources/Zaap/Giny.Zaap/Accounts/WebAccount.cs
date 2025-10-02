namespace Giny.Zaap.Accounts;

public class WebAccount
{
    public int Id
    {
        get;
        set;
    }

    public string Username
    {
        get;
        set;
    }
    public string Password
    {
        get;
        set;
    }
    public string Nickname
    {
        get;
        set;
    }

    public byte CharacterSlots
    {
        get;
        set;
    }

    public byte Role
    {
        get;
        set;
    }
    public char AvatarLetter => char.ToUpper(Username[0]);
}