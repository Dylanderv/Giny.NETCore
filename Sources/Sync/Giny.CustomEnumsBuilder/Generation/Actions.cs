using Giny.AS3;
using Giny.AS3.Expressions;
using Giny.EnumsBuilder.Generation;
using Giny.IO.D2O;
using System.Text;

namespace Giny.CustomEnumsBuilder.Generation;

public class Actions : CustomEnum
{
    public override string ClassName => "ActionsEnum";

    protected override string GenerateEnumContent(List<D2OReader> readers)
    {
        StringBuilder sb = new StringBuilder();

        AS3File file = new AS3File("AS3/ActionIds.as");

        foreach (var field in file.Fields)
        {
            var fieldValue = field.GetValue<ConstantIntExpression>();

            sb.AppendLine(field.Name + " = " + fieldValue.Value + ",");
        }
        return sb.ToString();
    }
}