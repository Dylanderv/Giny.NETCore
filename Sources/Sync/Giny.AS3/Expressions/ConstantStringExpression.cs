namespace Giny.AS3.Expressions;

public class ConstantStringExpression : ConstantExpression
{
    public ConstantStringExpression(string line) : base(line)
    {
        this.Value = line;
    }
    public static bool IsValid(string line)
    {
        return line.StartsWith("\"") && line.EndsWith("\"");
    }
    public override void RenameVariable(string variableName, string newVariableName)
    {
            
    }
    public override void RenameType(string typeName, string newTypeName)
    {

    }
    public override void RenameMethodCall(string methodName, string newMethodName)
    {

    }

    public override string GetValueString()
    {
        return (string)Value;
    }
}