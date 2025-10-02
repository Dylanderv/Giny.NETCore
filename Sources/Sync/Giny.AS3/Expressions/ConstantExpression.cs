namespace Giny.AS3.Expressions;

public abstract class ConstantExpression : BaseExpression
{
    public object Value
    {
        get;
        protected set;
    }
    public ConstantExpression(string line) : base(line)
    {

    }
    public abstract string GetValueString();
}