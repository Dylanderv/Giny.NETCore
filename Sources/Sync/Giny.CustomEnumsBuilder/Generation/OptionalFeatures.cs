using Giny.IO.D2O;
using System.Text;

namespace Giny.EnumsBuilder.Generation;

public class OptionalFeatures : CustomEnum
{
    public override string ClassName => "OptionalFeaturesEnum";

    protected override string GenerateEnumContent(List<D2OReader> readers)
    {
        var opts = readers.FirstOrDefault(x => x.Classes.Any(w => w.Value.Name == "OptionalFeature")).EnumerateObjects().Cast<Giny.IO.D2OClasses.OptionalFeature>();

        StringBuilder sb = new StringBuilder();

        foreach (var opt in opts)
        {
            sb.AppendLine(ApplyRules(opt.keyword) + "=" + opt.id + ",");
        }
        return sb.ToString();
    }
}