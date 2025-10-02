namespace Giny.AS3.Expressions;

public abstract class BaseExpression
{
    public string Line
    {
        get;
        set;
    }
    public int LineSkip
    {
        get;
        set;
    }
    public virtual bool HasBracket
    {
        get;
    }
    protected ParentExpression Parent
    {
        get;
        private set;
    }
    public BaseExpression(string line)
    {
        this.Line = line;
        this.LineSkip = 1;
    }

    public abstract void RenameVariable(string variableName, string newVariableName);

    public abstract void RenameType(string typeName, string newTypeName);

    public abstract void RenameMethodCall(string methodName, string newMethodName);
}