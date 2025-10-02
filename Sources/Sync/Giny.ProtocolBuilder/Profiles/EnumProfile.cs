using Giny.AS3;
using Giny.ProtocolBuilder.Converters;

namespace Giny.ProtocolBuilder.Profiles;

public class EnumProfile : Profile
{
    public EnumProfile(string as3FilePath) : base(as3FilePath)
    {

    }

    public override string TemplateFileName => "EnumTemplate.tt";

    public override string RelativeOutputPath => String.Empty;

    public override string OutputDirectory => Path.Combine(Environment.CurrentDirectory, Constants.ENUMS_OUTPUT_PATH);

    public override DofusConverter CreateDofusConverter(AS3File file)
    {
        return new EnumConverter(file);
    }

    public override bool Skip(AS3File file)
    {
        return false;
    }
}