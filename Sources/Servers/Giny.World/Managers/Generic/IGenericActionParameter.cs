namespace Giny.World.Managers.Generic;

public interface IGenericAction
{
    GenericActionEnum ActionIdentifier
    {
        get;
        set;
    }
    string Param1
    {
        get;
        set;
    }
    string Param2
    {
        get;
        set;
    }
    string Param3
    {
        get;
        set;
    }
    string Criteria
    {
        get;
        set;
    }
}